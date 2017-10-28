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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(224, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("creature", "crea", "obje", typeof(CreatureBlock))]
    public class CreatureBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("default team", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(DefaultTeamOptions), false)]
        public Int16 DefaultTeam;
        [Abide.Guerilla.Tags.FieldAttribute("motion sensor blip size", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(MotionSensorBlipSizeOptions), false)]
        public Int16 MotionSensorBlipSize;
        [Abide.Guerilla.Tags.FieldAttribute("turning velocity maximum:degrees per second", typeof(Single))]
        public Single TurningVelocityMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("turning acceleration maximum:degrees per second squared", typeof(Single))]
        public Single TurningAccelerationMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("casual turning modifier:[0,1]", typeof(Single))]
        public Single CasualTurningModifier;
        [Abide.Guerilla.Tags.FieldAttribute("autoaim width:world units", typeof(Single))]
        public Single AutoaimWidth;
        [Abide.Guerilla.Tags.FieldAttribute("physics", typeof(CharacterPhysicsStructBlock))]
        public CharacterPhysicsStructBlock Physics;
        [Abide.Guerilla.Tags.FieldAttribute("impact damage", typeof(TagReference))]
        public TagReference ImpactDamage;
        [Abide.Guerilla.Tags.FieldAttribute("impact shield damage#if not specified, uses \'impact damage\'", typeof(TagReference))]
        public TagReference ImpactShieldDamage;
        public enum FlagsOptions
        {
            Unused = 1,
            InfectionForm = 2,
            ImmuneToFallingDamage = 4,
            RotateWhileAirborne = 8,
            ZappedByShields = 16,
            AttachUponImpact = 32,
            NotOnMotionSensor = 64,
        }
        public enum DefaultTeamOptions
        {
            Default = 0,
            Player = 1,
            Human = 2,
            Covenant = 3,
            Flood = 4,
            Sentinel = 5,
            Heretic = 6,
            Prophet = 7,
            Unused8 = 8,
            Unused9 = 9,
            Unused10 = 10,
            Unused11 = 11,
            Unused12 = 12,
            Unused13 = 13,
            Unused14 = 14,
            Unused15 = 15,
        }
        public enum MotionSensorBlipSizeOptions
        {
            Medium = 0,
            Small = 1,
            Large = 2,
        }
    }
}
#pragma warning restore CS1591
