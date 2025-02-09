namespace TwinStickShooter
{
  using UnityEngine;
  using Quantum;
  using Photon.Deterministic;

  public enum EPreviewType
  {
    None,
    Linear,
    Ballistic,
    Angle
  }

  public unsafe class AttackPreview : QuantumSceneViewComponent<CustomViewContext>
  {
    public EPreviewType PreviewType;
    public EPreviewType SpecialPreviewType;

    [SerializeField] private FP _maxDistance;

    [SerializeField] private GameObject _previewsContainer;

    [SerializeField] private GameObject _linearPreview;
    [SerializeField] private GameObject _ballisticPreview;
    [SerializeField] private GameObject _anglePreview;

    [SerializeField] private GameObject _ballisticPreviewCircle;

    private MeshRenderer[] _meshRenderer;
    [SerializeField] private Color _standardAimMaterialColor;
    [SerializeField] private Color _blockedMaterialColor;

    private void Awake()
    {
      _meshRenderer = GetComponentsInChildren<MeshRenderer>(true);
    }

    private void TogglePreviews(EPreviewType previewType)
    {
      switch (previewType)
      {
        case EPreviewType.None:
          _linearPreview.SetActive(false);
          _ballisticPreview.SetActive(false);
          _anglePreview.SetActive(false);
          break;
        case EPreviewType.Linear:
          _ballisticPreview.SetActive(false);
          _ballisticPreviewCircle.SetActive(false);
          _anglePreview.SetActive(false);

          _linearPreview.SetActive(true);
          break;
        case EPreviewType.Ballistic:
          _linearPreview.SetActive(false);
          _anglePreview.SetActive(false);

          _ballisticPreview.SetActive(true);
          _ballisticPreviewCircle.SetActive(true);
          break;
        case EPreviewType.Angle:
          _linearPreview.SetActive(false);
          _ballisticPreviewCircle.SetActive(false);
          _ballisticPreview.SetActive(false);

          _anglePreview.SetActive(true);
          break;
      }
    }

    public void UpdateAttackPreview(FPVector2 aim, bool isSpecial)
    {
      EPreviewType previewType = isSpecial ? SpecialPreviewType : PreviewType;
      TogglePreviews(previewType);

      var aimNormalized = aim.Normalized;
      transform.position = ViewContext.LocalView.transform.position + Vector3.up * .2f;

      Frame frame = QuantumRunner.Default.Game.Frames.Predicted;

      if (previewType != EPreviewType.Angle)
      {
        float previewSize = previewType == EPreviewType.Linear
          ? GetPreviewSizeLinear(frame, aimNormalized)
          : GetPreviewSizeBallistic(aim);
        _previewsContainer.transform.localScale = new Vector3(1, 1, previewSize);
      }
      else
      {
        _previewsContainer.transform.localScale = new Vector3(1, 1, 1);
      }

      _previewsContainer.transform.LookAt(transform.position +
                                          new Vector3(aimNormalized.X.AsFloat, 0, aimNormalized.Y.AsFloat));

      if (previewType == EPreviewType.Ballistic)
      {
        Transform2D characterTransform = frame.Get<Transform2D>(ViewContext.LocalView.EntityRef);
        var circlePosition = characterTransform.Position +
                             aim.Normalized * Mathf.Clamp(aim.Magnitude.AsFloat, 0, _maxDistance.AsFloat).ToFP();
        _ballisticPreviewCircle.transform.position =
          new Vector3(circlePosition.X.AsFloat, .2f, circlePosition.Y.AsFloat);
      }

      EAttributeType type = isSpecial ? EAttributeType.Special : EAttributeType.Energy;
      float attackLoad = AttributesHelper.GetCurrentValue(frame, ViewContext.LocalView.EntityRef, type).AsFloat;
      foreach (var mesh in _meshRenderer)
      {
        if (attackLoad < GetSkillCost(frame, ViewContext.LocalView.EntityRef, isSpecial))
        {
          mesh.material.color = _blockedMaterialColor;
        }
        else
        {
          mesh.material.color = _standardAimMaterialColor;
        }
      }
    }

    private float GetSkillCost(Frame frame, EntityRef character, bool isSpecial)
    {
      CharacterAttacks attack = frame.Get<CharacterAttacks>(character);
      if (isSpecial)
        return frame.FindAsset<SkillData>(attack.SpecialSkillData.Id).Cost.AsFloat;
      return frame.FindAsset<SkillData>(attack.BasicSkillData.Id).Cost.AsFloat;
    }

    private float GetPreviewSizeLinear(Frame frame, FPVector2 aimDirection)
    {
      Transform2D characterTransform = frame.Get<Transform2D>(ViewContext.LocalView.EntityRef);
      var hit = frame.Physics2D.Raycast(characterTransform.Position, aimDirection, _maxDistance,
        frame.Layers.GetLayerMask("Static"));
      if (hit.HasValue == false)
      {
        return _maxDistance.AsFloat;
      }

      var previewSize =
        Vector2.Distance(characterTransform.Position.ToUnityVector2(), hit.Value.Point.ToUnityVector2());
      return previewSize;
    }

    private float GetPreviewSizeBallistic(FPVector2 aim)
    {
      return Mathf.Clamp(aim.Magnitude.AsFloat, 0, _maxDistance.AsFloat);
    }
  }
}