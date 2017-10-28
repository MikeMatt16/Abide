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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(40, 4)]
    public class NewHudSoundBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("chief sound^", typeof(TagReference))]
        public TagReference ChiefSound;
        [Abide.Guerilla.Tags.FieldAttribute("latched to", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(LatchedToOptions), true)]
        public Int32 LatchedTo;
        [Abide.Guerilla.Tags.FieldAttribute("scale", typeof(Single))]
        public Single Scale;
        [Abide.Guerilla.Tags.FieldAttribute("dervish sound", typeof(TagReference))]
        public TagReference DervishSound;
        public enum LatchedToOptions
        {
            ShieldRecharging = 1,
            ShieldDamaged = 2,
            ShieldLow = 4,
            ShieldEmpty = 8,
            HealthLow = 16,
            HealthEmpty = 32,
            HealthMinorDamage = 64,
            HealthMajorDamage = 128,
            RocketLocking = 256,
            RocketLocked = 512,
        }
    }
}
#pragma warning restore CS1591
