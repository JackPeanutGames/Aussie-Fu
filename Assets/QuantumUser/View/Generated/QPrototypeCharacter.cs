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
  using UnityEngine;
  
  [UnityEngine.DisallowMultipleComponent()]
  public unsafe partial class QPrototypeCharacter : QuantumUnityComponentPrototype<Quantum.Prototypes.CharacterPrototype>, IQuantumUnityPrototypeWrapperForComponent<Quantum.Character> {
    partial void CreatePrototypeUser(Quantum.QuantumEntityPrototypeConverter converter, ref Quantum.Prototypes.CharacterPrototype prototype);
    [DrawInline()]
    [ReadOnly(InEditMode = false)]
    public Quantum.Prototypes.CharacterPrototype Prototype;
    public override System.Type ComponentType {
      get {
        return typeof(Quantum.Character);
      }
    }
    public override ComponentPrototype CreatePrototype(Quantum.QuantumEntityPrototypeConverter converter) {
      CreatePrototypeUser(converter, ref Prototype);
      return Prototype;
    }
  }
}
#pragma warning restore 0109
#pragma warning restore 1591
