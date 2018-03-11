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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(396, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("unit", "unit", "obje", typeof(UnitBlock))]
    public class UnitBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("default team", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(DefaultTeamOptions), false)]
        public Int16 DefaultTeam;
        [Abide.Guerilla.Tags.FieldAttribute("constant sound volume", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ConstantSoundVolumeOptions), false)]
        public Int16 ConstantSoundVolume;
        [Abide.Guerilla.Tags.FieldAttribute("integrated light toggle", typeof(TagReference))]
        public TagReference IntegratedLightToggle;
        [Abide.Guerilla.Tags.FieldAttribute("camera field of view:degrees", typeof(Single))]
        public Single CameraFieldOfView;
        [Abide.Guerilla.Tags.FieldAttribute("camera stiffness", typeof(Single))]
        public Single CameraStiffness;
        [Abide.Guerilla.Tags.FieldAttribute("unit camera", typeof(UnitCameraStructBlock))]
        public UnitCameraStructBlock UnitCamera;
        [Abide.Guerilla.Tags.FieldAttribute("acceleration", typeof(UnitSeatAccelerationStructBlock))]
        public UnitSeatAccelerationStructBlock Acceleration;
        [Abide.Guerilla.Tags.FieldAttribute("soft ping threshold:[0,1]", typeof(Single))]
        public Single SoftPingThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("soft ping interrupt time:seconds", typeof(Single))]
        public Single SoftPingInterruptTime;
        [Abide.Guerilla.Tags.FieldAttribute("hard ping threshold:[0,1]", typeof(Single))]
        public Single HardPingThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("hard ping interrupt time:seconds", typeof(Single))]
        public Single HardPingInterruptTime;
        [Abide.Guerilla.Tags.FieldAttribute("hard death threshold:[0,1]", typeof(Single))]
        public Single HardDeathThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("feign death threshold:[0,1]", typeof(Single))]
        public Single FeignDeathThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("feign death time:seconds", typeof(Single))]
        public Single FeignDeathTime;
        [Abide.Guerilla.Tags.FieldAttribute("distance of evade anim:world units#this must be set to tell the AI how far it sho" +
            "uld expect our evade animation to move us", typeof(Single))]
        public Single DistanceOfEvadeAnim;
        [Abide.Guerilla.Tags.FieldAttribute("distance of dive anim:world units#this must be set to tell the AI how far it shou" +
            "ld expect our dive animation to move us", typeof(Single))]
        public Single DistanceOfDiveAnim;
        [Abide.Guerilla.Tags.FieldAttribute("stunned movement threshold:[0,1]#if we take this much damage in a short space of " +
            "time we will play our \'stunned movement\' animations", typeof(Single))]
        public Single StunnedMovementThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("feign death chance:[0,1]", typeof(Single))]
        public Single FeignDeathChance;
        [Abide.Guerilla.Tags.FieldAttribute("feign repeat chance:[0,1]", typeof(Single))]
        public Single FeignRepeatChance;
        [Abide.Guerilla.Tags.FieldAttribute("spawned turret character#automatically created character when this unit is driven" +
            "", typeof(TagReference))]
        public TagReference SpawnedTurretCharacter;
        [Abide.Guerilla.Tags.FieldAttribute("spawned velocity#velocity at which we throw spawned actors", typeof(Single))]
        public Single SpawnedVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("aiming velocity maximum:degrees per second", typeof(Single))]
        public Single AimingVelocityMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("aiming acceleration maximum:degrees per second squared", typeof(Single))]
        public Single AimingAccelerationMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("casual aiming modifier:[0,1]", typeof(Single))]
        public Single CasualAimingModifier;
        [Abide.Guerilla.Tags.FieldAttribute("looking velocity maximum:degrees per second", typeof(Single))]
        public Single LookingVelocityMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("looking acceleration maximum:degrees per second squared", typeof(Single))]
        public Single LookingAccelerationMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("right_hand_node#where the primary weapon is attached", typeof(StringId))]
        public StringId RightHandNode;
        [Abide.Guerilla.Tags.FieldAttribute("left_hand_node#where the seconday weapon is attached (for dual-pistol modes)", typeof(StringId))]
        public StringId LeftHandNode;
        [Abide.Guerilla.Tags.FieldAttribute("more damn nodes", typeof(UnitAdditionalNodeNamesStructBlock))]
        public UnitAdditionalNodeNamesStructBlock MoreDamnNodes;
        [Abide.Guerilla.Tags.FieldAttribute("melee damage", typeof(TagReference))]
        public TagReference MeleeDamage;
        [Abide.Guerilla.Tags.FieldAttribute("your momma", typeof(UnitBoardingMeleeStructBlock))]
        public UnitBoardingMeleeStructBlock YourMomma;
        [Abide.Guerilla.Tags.FieldAttribute("motion sensor blip size", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(MotionSensorBlipSizeOptions), false)]
        public Int16 MotionSensorBlipSize;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("postures", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Unit Postures Block", 20, typeof(UnitPosturesBlock))]
        public TagBlock Postures;
        [Abide.Guerilla.Tags.FieldAttribute("NEW HUD INTERFACES", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Unit Hud Reference Block", 2, typeof(UnitHudReferenceBlock))]
        public TagBlock NewHudInterfaces;
        [Abide.Guerilla.Tags.FieldAttribute("dialogue variants", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Dialogue Variant Block", 16, typeof(DialogueVariantBlock))]
        public TagBlock DialogueVariants;
        [Abide.Guerilla.Tags.FieldAttribute("grenade velocity:world units per second", typeof(Single))]
        public Single GrenadeVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("grenade type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(GrenadeTypeOptions), false)]
        public Int16 GrenadeType;
        [Abide.Guerilla.Tags.FieldAttribute("grenade count", typeof(Int16))]
        public Int16 GrenadeCount;
        [Abide.Guerilla.Tags.FieldAttribute("powered seats", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Powered Seat Block", 2, typeof(PoweredSeatBlock))]
        public TagBlock PoweredSeats;
        [Abide.Guerilla.Tags.FieldAttribute("weapons", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Unit Weapon Block", 4, typeof(UnitWeaponBlock))]
        public TagBlock Weapons;
        [Abide.Guerilla.Tags.FieldAttribute("seats", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Unit Seat Block", 32, typeof(UnitSeatBlock))]
        public TagBlock Seats;
        [Abide.Guerilla.Tags.FieldAttribute("boost", typeof(UnitBoostStructBlock))]
        public UnitBoostStructBlock Boost1;
        [Abide.Guerilla.Tags.FieldAttribute("lipsync", typeof(UnitLipsyncScalesStructBlock))]
        public UnitLipsyncScalesStructBlock Lipsync1;
        public enum FlagsOptions
        {
            CircularAiming = 1,
            DestroyedAfterDying = 2,
            HalfspeedInterpolation = 4,
            FiresFromCamera = 8,
            EntranceInsideBoundingSphere = 16,
            DoesntShowReadiedWeapon = 32,
            CausesPassengerDialogue = 64,
            ResistsPings = 128,
            MeleeAttackIsFatal = 256,
            DontRefaceDuringPings = 512,
            HasNoAiming = 1024,
            SimpleCreature = 2048,
            ImpactMeleeAttachesToUnit = 4096,
            ImpactMeleeDiesOnShields = 8192,
            CannotOpenDoorsAutomatically = 16384,
            MeleeAttackersCannotAttach = 32768,
            NotInstantlyKilledByMelee = 65536,
            ShieldSapping = 131072,
            RunsAroundFlaming = 262144,
            Inconsequential = 524288,
            SpecialCinematicUnit = 1048576,
            IgnoredByAutoaiming = 2097152,
            ShieldsFryInfectionForms = 4194304,
            Unused = 8388608,
            Unused1 = 16777216,
            ActsAsGunnerForParent = 33554432,
            ControlledByParentGunner = 67108864,
            ParentsPrimaryWeapon = 134217728,
            UnitHasBoost = 268435456,
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
        public enum ConstantSoundVolumeOptions
        {
            Silent = 0,
            Medium = 1,
            Loud = 2,
            Shout = 3,
            Quiet = 4,
        }
        public enum MotionSensorBlipSizeOptions
        {
            Medium = 0,
            Small = 1,
            Large = 2,
        }
        public enum GrenadeTypeOptions
        {
            HumanFragmentation = 0,
            CovenantPlasma = 1,
        }
    }
}
#pragma warning restore CS1591