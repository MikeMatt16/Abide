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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(72, 4)]
    public class CharacterChargeBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Charge flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ChargeFlagsOptions), true)]
        public Int32 ChargeFlags;
        [Abide.Guerilla.Tags.FieldAttribute("melee consider range", typeof(Single))]
        public Single MeleeConsiderRange;
        [Abide.Guerilla.Tags.FieldAttribute("melee chance#chance of initiating a melee within a 1 second period", typeof(Single))]
        public Single MeleeChance;
        [Abide.Guerilla.Tags.FieldAttribute("melee attack range", typeof(Single))]
        public Single MeleeAttackRange;
        [Abide.Guerilla.Tags.FieldAttribute("melee abort range", typeof(Single))]
        public Single MeleeAbortRange;
        [Abide.Guerilla.Tags.FieldAttribute("melee attack timeout:seconds#Give up after given amount of time spent charging", typeof(Single))]
        public Single MeleeAttackTimeout;
        [Abide.Guerilla.Tags.FieldAttribute("melee attack delay timer:seconds#don\'t attempt again before given time since last" +
            " melee", typeof(Single))]
        public Single MeleeAttackDelayTimer;
        [Abide.Guerilla.Tags.FieldAttribute("melee leap chance", typeof(Single))]
        public Single MeleeLeapChance;
        [Abide.Guerilla.Tags.FieldAttribute("ideal leap velocity", typeof(Single))]
        public Single IdealLeapVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("max leap velocity", typeof(Single))]
        public Single MaxLeapVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("melee leap ballistic", typeof(Single))]
        public Single MeleeLeapBallistic;
        [Abide.Guerilla.Tags.FieldAttribute("melee delay timer:seconds#time between melee leaps", typeof(Single))]
        public Single MeleeDelayTimer;
        [Abide.Guerilla.Tags.FieldAttribute("berserk weapon#when I berserk, I pull out a ...", typeof(TagReference))]
        public TagReference BerserkWeapon;
        public enum ChargeFlagsOptions
        {
            OffhandMeleeAllowed = 1,
            BerserkWheneverCharge = 2,
        }
    }
}
#pragma warning restore CS1591
