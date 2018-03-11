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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("equipment", "eqip", "item", typeof(EquipmentBlock))]
    public class EquipmentBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("powerup type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(PowerupTypeOptions), false)]
        public Int16 PowerupType;
        [Abide.Guerilla.Tags.FieldAttribute("grenade type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(GrenadeTypeOptions), false)]
        public Int16 GrenadeType;
        [Abide.Guerilla.Tags.FieldAttribute("powerup time:seconds", typeof(Single))]
        public Single PowerupTime;
        [Abide.Guerilla.Tags.FieldAttribute("pickup sound", typeof(TagReference))]
        public TagReference PickupSound;
        public enum PowerupTypeOptions
        {
            None = 0,
            DoubleSpeed = 1,
            OverShield = 2,
            ActiveCamouflage = 3,
            FullspectrumVision = 4,
            Health = 5,
            Grenade = 6,
        }
        public enum GrenadeTypeOptions
        {
            HumanFragmentation = 0,
            CovenantPlasma = 1,
        }
    }
}
#pragma warning restore CS1591