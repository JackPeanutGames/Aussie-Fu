// <auto-generated>
// This code was auto-generated by a tool, every time
// the tool executes this code will be reset.
//
// If you need to extend the classes generated to add
// fields or methods to them, please create partial
// declarations in another file.
// </auto-generated>
#pragma warning disable 0109
#pragma warning disable 1591


namespace Quantum {
  using Photon.Deterministic;
  using Quantum;
  using Quantum.Core;
  using Quantum.Collections;
  using Quantum.Inspector;
  using Quantum.Physics2D;
  using Quantum.Physics3D;
  using Byte = System.Byte;
  using SByte = System.SByte;
  using Int16 = System.Int16;
  using UInt16 = System.UInt16;
  using Int32 = System.Int32;
  using UInt32 = System.UInt32;
  using Int64 = System.Int64;
  using UInt64 = System.UInt64;
  using Boolean = System.Boolean;
  using String = System.String;
  using Object = System.Object;
  using FlagsAttribute = System.FlagsAttribute;
  using SerializableAttribute = System.SerializableAttribute;
  using MethodImplAttribute = System.Runtime.CompilerServices.MethodImplAttribute;
  using MethodImplOptions = System.Runtime.CompilerServices.MethodImplOptions;
  using FieldOffsetAttribute = System.Runtime.InteropServices.FieldOffsetAttribute;
  using StructLayoutAttribute = System.Runtime.InteropServices.StructLayoutAttribute;
  using LayoutKind = System.Runtime.InteropServices.LayoutKind;
  #if QUANTUM_UNITY //;
  using TooltipAttribute = UnityEngine.TooltipAttribute;
  using HeaderAttribute = UnityEngine.HeaderAttribute;
  using SpaceAttribute = UnityEngine.SpaceAttribute;
  using RangeAttribute = UnityEngine.RangeAttribute;
  using HideInInspectorAttribute = UnityEngine.HideInInspector;
  using PreserveAttribute = UnityEngine.Scripting.PreserveAttribute;
  using FormerlySerializedAsAttribute = UnityEngine.Serialization.FormerlySerializedAsAttribute;
  using MovedFromAttribute = UnityEngine.Scripting.APIUpdating.MovedFromAttribute;
  using CreateAssetMenu = UnityEngine.CreateAssetMenuAttribute;
  using RuntimeInitializeOnLoadMethodAttribute = UnityEngine.RuntimeInitializeOnLoadMethodAttribute;
  #endif //;
  
  public unsafe partial class Frame {
    public unsafe partial struct FrameEvents {
      static partial void GetEventTypeCountCodeGen(ref Int32 eventCount) {
        eventCount = 14;
      }
      static partial void GetParentEventIDCodeGen(Int32 eventID, ref Int32 parentEventID) {
        switch (eventID) {
          default: break;
        }
      }
      static partial void GetEventTypeCodeGen(Int32 eventID, ref System.Type result) {
        switch (eventID) {
          case EventOnCreateAttack.ID: result = typeof(EventOnCreateAttack); return;
          case EventCharacterDefeated.ID: result = typeof(EventCharacterDefeated); return;
          case EventCharacterRespawned.ID: result = typeof(EventCharacterRespawned); return;
          case EventCharacterDamaged.ID: result = typeof(EventCharacterDamaged); return;
          case EventCharacterHealed.ID: result = typeof(EventCharacterHealed); return;
          case EventFinishCharacterSelection.ID: result = typeof(EventFinishCharacterSelection); return;
          case EventStartCharacterSelection.ID: result = typeof(EventStartCharacterSelection); return;
          case EventArenaPresentation.ID: result = typeof(EventArenaPresentation); return;
          case EventCountdownStarted.ID: result = typeof(EventCountdownStarted); return;
          case EventCountdownStopped.ID: result = typeof(EventCountdownStopped); return;
          case EventGameOver.ID: result = typeof(EventGameOver); return;
          case EventCharacterSkill.ID: result = typeof(EventCharacterSkill); return;
          case EventSkillAction.ID: result = typeof(EventSkillAction); return;
          default: break;
        }
      }
      public EventOnCreateAttack OnCreateAttack(AssetGuid skillData) {
        var ev = _f.Context.AcquireEvent<EventOnCreateAttack>(EventOnCreateAttack.ID);
        ev.skillData = skillData;
        _f.AddEvent(ev);
        return ev;
      }
      public EventCharacterDefeated CharacterDefeated(EntityRef character) {
        var ev = _f.Context.AcquireEvent<EventCharacterDefeated>(EventCharacterDefeated.ID);
        ev.character = character;
        _f.AddEvent(ev);
        return ev;
      }
      public EventCharacterRespawned CharacterRespawned(EntityRef character) {
        var ev = _f.Context.AcquireEvent<EventCharacterRespawned>(EventCharacterRespawned.ID);
        ev.character = character;
        _f.AddEvent(ev);
        return ev;
      }
      public EventCharacterDamaged CharacterDamaged(EntityRef target, FP damage) {
        var ev = _f.Context.AcquireEvent<EventCharacterDamaged>(EventCharacterDamaged.ID);
        ev.target = target;
        ev.damage = damage;
        _f.AddEvent(ev);
        return ev;
      }
      public EventCharacterHealed CharacterHealed(EntityRef character) {
        var ev = _f.Context.AcquireEvent<EventCharacterHealed>(EventCharacterHealed.ID);
        ev.character = character;
        _f.AddEvent(ev);
        return ev;
      }
      public EventFinishCharacterSelection FinishCharacterSelection() {
        if (_f.IsPredicted) return null;
        var ev = _f.Context.AcquireEvent<EventFinishCharacterSelection>(EventFinishCharacterSelection.ID);
        _f.AddEvent(ev);
        return ev;
      }
      public EventStartCharacterSelection StartCharacterSelection() {
        if (_f.IsPredicted) return null;
        var ev = _f.Context.AcquireEvent<EventStartCharacterSelection>(EventStartCharacterSelection.ID);
        _f.AddEvent(ev);
        return ev;
      }
      public EventArenaPresentation ArenaPresentation() {
        if (_f.IsPredicted) return null;
        var ev = _f.Context.AcquireEvent<EventArenaPresentation>(EventArenaPresentation.ID);
        _f.AddEvent(ev);
        return ev;
      }
      public EventCountdownStarted CountdownStarted() {
        if (_f.IsPredicted) return null;
        var ev = _f.Context.AcquireEvent<EventCountdownStarted>(EventCountdownStarted.ID);
        _f.AddEvent(ev);
        return ev;
      }
      public EventCountdownStopped CountdownStopped() {
        if (_f.IsPredicted) return null;
        var ev = _f.Context.AcquireEvent<EventCountdownStopped>(EventCountdownStopped.ID);
        _f.AddEvent(ev);
        return ev;
      }
      public EventGameOver GameOver(Int32 WinnerTeam) {
        if (_f.IsPredicted) return null;
        var ev = _f.Context.AcquireEvent<EventGameOver>(EventGameOver.ID);
        ev.WinnerTeam = WinnerTeam;
        _f.AddEvent(ev);
        return ev;
      }
      public EventCharacterSkill CharacterSkill(EntityRef character) {
        var ev = _f.Context.AcquireEvent<EventCharacterSkill>(EventCharacterSkill.ID);
        ev.character = character;
        _f.AddEvent(ev);
        return ev;
      }
      public EventSkillAction SkillAction(AssetGuid skillData) {
        var ev = _f.Context.AcquireEvent<EventSkillAction>(EventSkillAction.ID);
        ev.skillData = skillData;
        _f.AddEvent(ev);
        return ev;
      }
    }
  }
  public unsafe partial class EventOnCreateAttack : EventBase {
    public new const Int32 ID = 1;
    public AssetGuid skillData;
    protected EventOnCreateAttack(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventOnCreateAttack() : 
        base(1, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 41;
        hash = hash * 31 + skillData.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventCharacterDefeated : EventBase {
    public new const Int32 ID = 2;
    public EntityRef character;
    protected EventCharacterDefeated(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCharacterDefeated() : 
        base(2, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 43;
        hash = hash * 31 + character.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventCharacterRespawned : EventBase {
    public new const Int32 ID = 3;
    public EntityRef character;
    protected EventCharacterRespawned(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCharacterRespawned() : 
        base(3, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 47;
        hash = hash * 31 + character.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventCharacterDamaged : EventBase {
    public new const Int32 ID = 4;
    public EntityRef target;
    public FP damage;
    protected EventCharacterDamaged(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCharacterDamaged() : 
        base(4, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 53;
        hash = hash * 31 + target.GetHashCode();
        hash = hash * 31 + damage.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventCharacterHealed : EventBase {
    public new const Int32 ID = 5;
    public EntityRef character;
    protected EventCharacterHealed(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCharacterHealed() : 
        base(5, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 59;
        hash = hash * 31 + character.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventFinishCharacterSelection : EventBase {
    public new const Int32 ID = 6;
    protected EventFinishCharacterSelection(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventFinishCharacterSelection() : 
        base(6, EventFlags.Server|EventFlags.Client|EventFlags.Synced) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 61;
        return hash;
      }
    }
  }
  public unsafe partial class EventStartCharacterSelection : EventBase {
    public new const Int32 ID = 7;
    protected EventStartCharacterSelection(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventStartCharacterSelection() : 
        base(7, EventFlags.Server|EventFlags.Client|EventFlags.Synced) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 67;
        return hash;
      }
    }
  }
  public unsafe partial class EventArenaPresentation : EventBase {
    public new const Int32 ID = 8;
    protected EventArenaPresentation(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventArenaPresentation() : 
        base(8, EventFlags.Server|EventFlags.Client|EventFlags.Synced) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 71;
        return hash;
      }
    }
  }
  public unsafe partial class EventCountdownStarted : EventBase {
    public new const Int32 ID = 9;
    protected EventCountdownStarted(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCountdownStarted() : 
        base(9, EventFlags.Server|EventFlags.Client|EventFlags.Synced) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 73;
        return hash;
      }
    }
  }
  public unsafe partial class EventCountdownStopped : EventBase {
    public new const Int32 ID = 10;
    protected EventCountdownStopped(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCountdownStopped() : 
        base(10, EventFlags.Server|EventFlags.Client|EventFlags.Synced) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 79;
        return hash;
      }
    }
  }
  public unsafe partial class EventGameOver : EventBase {
    public new const Int32 ID = 11;
    public Int32 WinnerTeam;
    protected EventGameOver(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventGameOver() : 
        base(11, EventFlags.Server|EventFlags.Client|EventFlags.Synced) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 83;
        hash = hash * 31 + WinnerTeam.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventCharacterSkill : EventBase {
    public new const Int32 ID = 12;
    public EntityRef character;
    protected EventCharacterSkill(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventCharacterSkill() : 
        base(12, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 89;
        hash = hash * 31 + character.GetHashCode();
        return hash;
      }
    }
  }
  public unsafe partial class EventSkillAction : EventBase {
    public new const Int32 ID = 13;
    public AssetGuid skillData;
    protected EventSkillAction(Int32 id, EventFlags flags) : 
        base(id, flags) {
    }
    public EventSkillAction() : 
        base(13, EventFlags.Server|EventFlags.Client) {
    }
    public new QuantumGame Game {
      get {
        return (QuantumGame)base.Game;
      }
      set {
        base.Game = value;
      }
    }
    public override Int32 GetHashCode() {
      unchecked {
        var hash = 97;
        hash = hash * 31 + skillData.GetHashCode();
        return hash;
      }
    }
  }
}
#pragma warning restore 0109
#pragma warning restore 1591
