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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(348, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("projectile", "proj", "obje", typeof(ProjectileBlock))]
    public class ProjectileBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("detonation timer starts", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(DetonationTimerStartsOptions), false)]
        public Int16 DetonationTimerStarts;
        [Abide.Guerilla.Tags.FieldAttribute("impact noise", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ImpactNoiseOptions), false)]
        public Int16 ImpactNoise;
        [Abide.Guerilla.Tags.FieldAttribute("AI perception radius:world units", typeof(Single))]
        public Single AiPerceptionRadius;
        [Abide.Guerilla.Tags.FieldAttribute("collision radius:world units", typeof(Single))]
        public Single CollisionRadius;
        [Abide.Guerilla.Tags.FieldAttribute("arming time:seconds#won\'t detonate before this time elapses", typeof(Single))]
        public Single ArmingTime;
        [Abide.Guerilla.Tags.FieldAttribute("danger radius:world units", typeof(Single))]
        public Single DangerRadius;
        [Abide.Guerilla.Tags.FieldAttribute("minimum velocity:world units per second#detonates when slowed below this velocity" +
            "", typeof(Single))]
        public Single MinimumVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("maximum range:world units#detonates after travelling this distance", typeof(Single))]
        public Single MaximumRange;
        [Abide.Guerilla.Tags.FieldAttribute("detonation noise", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(DetonationNoiseOptions), false)]
        public Int16 DetonationNoise;
        [Abide.Guerilla.Tags.FieldAttribute("super det. projectile count", typeof(Int16))]
        public Int16 SuperDetProjectileCount;
        [Abide.Guerilla.Tags.FieldAttribute("detonation started", typeof(TagReference))]
        public TagReference DetonationStarted;
        [Abide.Guerilla.Tags.FieldAttribute("detonation effect (airborne)", typeof(TagReference))]
        public TagReference DetonationEffectAirborne;
        [Abide.Guerilla.Tags.FieldAttribute("detonation effect (ground)", typeof(TagReference))]
        public TagReference DetonationEffectGround;
        [Abide.Guerilla.Tags.FieldAttribute("detonation damage", typeof(TagReference))]
        public TagReference DetonationDamage;
        [Abide.Guerilla.Tags.FieldAttribute("attached detonation damage", typeof(TagReference))]
        public TagReference AttachedDetonationDamage;
        [Abide.Guerilla.Tags.FieldAttribute("super detonation", typeof(TagReference))]
        public TagReference SuperDetonation;
        [Abide.Guerilla.Tags.FieldAttribute("your momma!", typeof(SuperDetonationDamageStructBlock))]
        public SuperDetonationDamageStructBlock YourMomma;
        [Abide.Guerilla.Tags.FieldAttribute("detonation sound", typeof(TagReference))]
        public TagReference DetonationSound;
        [Abide.Guerilla.Tags.FieldAttribute("damage reporting type", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(DamageReportingTypeOptions), false)]
        public Byte DamageReportingType;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(3)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("super attached detonation damage", typeof(TagReference))]
        public TagReference SuperAttachedDetonationDamage;
        [Abide.Guerilla.Tags.FieldAttribute("material effect radius#radius within we will generate material effects", typeof(Single))]
        public Single MaterialEffectRadius;
        [Abide.Guerilla.Tags.FieldAttribute("flyby sound", typeof(TagReference))]
        public TagReference FlybySound;
        [Abide.Guerilla.Tags.FieldAttribute("impact effect", typeof(TagReference))]
        public TagReference ImpactEffect;
        [Abide.Guerilla.Tags.FieldAttribute("impact damage", typeof(TagReference))]
        public TagReference ImpactDamage;
        [Abide.Guerilla.Tags.FieldAttribute("boarding detonation time", typeof(Single))]
        public Single BoardingDetonationTime;
        [Abide.Guerilla.Tags.FieldAttribute("boarding detonation damage", typeof(TagReference))]
        public TagReference BoardingDetonationDamage;
        [Abide.Guerilla.Tags.FieldAttribute("boarding attached detonation damage", typeof(TagReference))]
        public TagReference BoardingAttachedDetonationDamage;
        [Abide.Guerilla.Tags.FieldAttribute("air gravity scale#the proportion of normal gravity applied to the projectile when" +
            " in air.", typeof(Single))]
        public Single AirGravityScale;
        [Abide.Guerilla.Tags.FieldAttribute("water gravity scale#the proportion of normal gravity applied to the projectile wh" +
            "en in water.", typeof(Single))]
        public Single WaterGravityScale;
        [Abide.Guerilla.Tags.FieldAttribute("initial velocity:world units per second#bullet\'s velocity when inflicting maximum" +
            " damage", typeof(Single))]
        public Single InitialVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("final velocity:world units per second#bullet\'s velocity when inflicting minimum d" +
            "amage", typeof(Single))]
        public Single FinalVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("blah", typeof(AngularVelocityLowerBoundStructBlock))]
        public AngularVelocityLowerBoundStructBlock Blah;
        [Abide.Guerilla.Tags.FieldAttribute("guided angular velocity (upper):degrees per second", typeof(Single))]
        public Single GuidedAngularVelocityUpper;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("targeted leading fraction", typeof(Single))]
        public Single TargetedLeadingFraction;
        [Abide.Guerilla.Tags.FieldAttribute("material responses", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Projectile Material Response Block", 200, typeof(ProjectileMaterialResponseBlock))]
        public TagBlock MaterialResponses;
        public enum FlagsOptions
        {
            OrientedAlongVelocity = 1,
            AiMustUseBallisticAiming = 2,
            DetonationMaxTimeIfAttached = 4,
            HasSuperCombiningExplosion = 8,
            DamageScalesBasedOnDistance = 16,
            TravelsInstantaneously = 32,
            SteeringAdjustsOrientation = 64,
            DontNoiseUpSteering = 128,
            CanTrackBehindItself = 256,
            RobotronSteering = 512,
            FasterWhenOwnedByPlayer = 1024,
        }
        public enum DetonationTimerStartsOptions
        {
            Immediately = 0,
            AfterFirstBounce = 1,
            WhenAtRest = 2,
            AfterFirstBounceOffAnySurface = 3,
        }
        public enum ImpactNoiseOptions
        {
            Silent = 0,
            Medium = 1,
            Loud = 2,
            Shout = 3,
            Quiet = 4,
        }
        public enum DetonationNoiseOptions
        {
            Silent = 0,
            Medium = 1,
            Loud = 2,
            Shout = 3,
            Quiet = 4,
        }
        public enum DamageReportingTypeOptions
        {
            TehGuardians11 = 0,
            FallingDamage = 1,
            GenericCollisionDamage = 2,
            GenericMeleeDamage = 3,
            GenericExplosion = 4,
            MagnumPistol = 5,
            PlasmaPistol = 6,
            Needler = 7,
            Smg = 8,
            PlasmaRifle = 9,
            BattleRifle = 10,
            Carbine = 11,
            Shotgun = 12,
            SniperRifle = 13,
            BeamRifle = 14,
            RocketLauncher = 15,
            FlakCannon = 16,
            BruteShot = 17,
            Disintegrator = 18,
            BrutePlasmaRifle = 19,
            EnergySword = 20,
            FragGrenade = 21,
            PlasmaGrenade = 22,
            FlagMeleeDamage = 23,
            BombMeleeDamage = 24,
            BombExplosionDamage = 25,
            BallMeleeDamage = 26,
            HumanTurret = 27,
            PlasmaTurret = 28,
            Banshee = 29,
            Ghost = 30,
            Mongoose = 31,
            Scorpion = 32,
            SpectreDriver = 33,
            SpectreGunner = 34,
            WarthogDriver = 35,
            WarthogGunner = 36,
            Wraith = 37,
            Tank = 38,
            SentinelBeam = 39,
            SentinelRpg = 40,
            Teleporter = 41,
        }
    }
}
#pragma warning restore CS1591
