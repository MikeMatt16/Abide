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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(120, 4)]
    public class SquadsBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(String32))]
        public String32 Name;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("team", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(TeamOptions), false)]
        public Int16 Team;
        [Abide.Guerilla.Tags.FieldAttribute("parent", typeof(Int16))]
        public Int16 Parent;
        [Abide.Guerilla.Tags.FieldAttribute("squad delay time:seconds", typeof(Single))]
        public Single SquadDelayTime;
        [Abide.Guerilla.Tags.FieldAttribute("normal diff count#initial number of actors on normal difficulty", typeof(Int16))]
        public Int16 NormalDiffCount;
        [Abide.Guerilla.Tags.FieldAttribute("insane diff count#initial number of actors on insane difficulty (hard difficulty " +
            "is midway between normal and insane)", typeof(Int16))]
        public Int16 InsaneDiffCount;
        [Abide.Guerilla.Tags.FieldAttribute("major upgrade", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(MajorUpgradeOptions), false)]
        public Int16 MajorUpgrade;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("vehicle type", typeof(Int16))]
        public Int16 VehicleType;
        [Abide.Guerilla.Tags.FieldAttribute("character type", typeof(Int16))]
        public Int16 CharacterType;
        [Abide.Guerilla.Tags.FieldAttribute("initial zone", typeof(Int16))]
        public Int16 InitialZone;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("initial weapon", typeof(Int16))]
        public Int16 InitialWeapon;
        [Abide.Guerilla.Tags.FieldAttribute("initial secondary weapon", typeof(Int16))]
        public Int16 InitialSecondaryWeapon;
        [Abide.Guerilla.Tags.FieldAttribute("grenade type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(GrenadeTypeOptions), false)]
        public Int16 GrenadeType;
        [Abide.Guerilla.Tags.FieldAttribute("initial order", typeof(Int16))]
        public Int16 InitialOrder;
        [Abide.Guerilla.Tags.FieldAttribute("vehicle variant", typeof(StringId))]
        public StringId VehicleVariant;
        [Abide.Guerilla.Tags.FieldAttribute("starting locations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Actor Starting Locations Block", 32, typeof(ActorStartingLocationsBlock))]
        public TagBlock StartingLocations;
        [Abide.Guerilla.Tags.FieldAttribute("Placement script", typeof(String32))]
        public String32 PlacementScript;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString6;
        public enum FlagsOptions
        {
            Unused = 1,
            NeverSearch = 2,
            StartTimerImmediately = 4,
            NoTimerDelayForever = 8,
            MagicSightAfterTimer = 16,
            AutomaticMigration = 32,
            Deprecated = 64,
            RespawnEnabled = 128,
            Blind = 256,
            Deaf = 512,
            Braindead = 1024,
            _3dFiringPositions = 2048,
            InitiallyPlaced = 4096,
            UnitsNotEnterableByPlayer = 8192,
        }
        public enum TeamOptions
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
        public enum MajorUpgradeOptions
        {
            Normal = 0,
            Few = 1,
            Many = 2,
            None = 3,
            All = 4,
        }
        public enum GrenadeTypeOptions
        {
            None = 0,
            HumanGrenade = 1,
            CovenantPlasma = 2,
        }
    }
}
#pragma warning restore CS1591
