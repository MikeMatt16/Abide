#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    public class PhysicsModelConstraintEdgeConstraintBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("type*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Type), false)]
        public Int16 Type1;
        [Abide.Guerilla.Tags.FieldAttribute("index*", typeof(Int16))]
        public Int16 Index;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("friction#0 is the default (takes what it was set in max) anything else overrides " +
            "that value", typeof(Single))]
        public Single Friction;
        public enum Type
        {
            Hinge = 0,
            LimitedHinge = 1,
            Ragdoll = 2,
            StiffSpring = 3,
            BallAndSocket = 4,
            Prismatic = 5,
        }
        public enum FlagsOptions
        {
            IsRigid = 1,
            DisableEffects = 2,
        }
    }
}
#pragma warning restore CS1591