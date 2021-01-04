//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated damage_effect_block tag block.
    /// </summary>
    public sealed class DamageEffectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageEffectBlock"/> class.
        /// </summary>
        public DamageEffectBlock()
        {
            this.Fields.Add(new RealBoundsField("radius:world units"));
            this.Fields.Add(new RealFractionField("cutoff scale:[0,1]"));
            this.Fields.Add(new LongFlagsField("flags", "don\'t scale damage by distance", "area damage players only#area of effect damage only affects players"));
            this.Fields.Add(new ExplanationField("damage", ""));
            this.Fields.Add(new EnumField("side effect", "none", "harmless", "lethal to the unsuspecting", "emp"));
            this.Fields.Add(new EnumField("category", "none", "falling", "bullet", "grenade", "high explosive", "sniper", "melee", "flame", "mounted weapon", "vehicle", "plasma", "needle", "shotgun"));
            this.Fields.Add(new LongFlagsField("flags", "does not hurt owner", "can cause headshots", "pings resistant units", "does not hurt friends", "does not ping units", "detonates explosives", "only hurts shields", "causes flaming death", "damage indicators always point down", "skips shields", "only hurts one infection form", "obsolete, was can cause multiplayer headshots", "infection form pop", "ignore seat scale for dir. dmg", "forces hard ping", "does not hurt players"));
            this.Fields.Add(new RealField("AOE core radius:world units#if this is area of effect damage"));
            this.Fields.Add(new RealField("damage lower bound"));
            this.Fields.Add(new RealBoundsField("damage upper bound"));
            this.Fields.Add(new AngleField("dmg inner cone angle"));
            this.Fields.Add(new StructField<DamageOuterConeAngleStructBlock>("blah"));
            this.Fields.Add(new RealField("active camouflage damage:[0,1]#how much more visible this damage makes a player w" +
                        "ho is active camouflaged"));
            this.Fields.Add(new RealField("stun:[0,1]#amount of stun added to damaged unit"));
            this.Fields.Add(new RealField("maximum stun:[0,1]#damaged unit\'s stun will never exceed this amount"));
            this.Fields.Add(new RealField("stun time:seconds#duration of stun due to this damage"));
            this.Fields.Add(new RealField("instantaneous acceleration:[0,+inf]"));
            this.Fields.Add(new RealField("rider direct damage scale"));
            this.Fields.Add(new RealField("rider maximum transfer damage scale"));
            this.Fields.Add(new RealField("rider minimum transfer damage scale"));
            this.Fields.Add(new StringIdField("general_damage"));
            this.Fields.Add(new StringIdField("specific_damage"));
            this.Fields.Add(new RealField("AI stun radius:world units"));
            this.Fields.Add(new RealBoundsField("AI stun bounds:(0-1)"));
            this.Fields.Add(new RealField("shake radius"));
            this.Fields.Add(new RealField("EMP radius"));
            this.Fields.Add(new BlockField<DamageEffectPlayerResponseBlock>("player responses", 2));
            this.Fields.Add(new ExplanationField("temporary camera impulse", ""));
            this.Fields.Add(new RealField("duration:seconds"));
            this.Fields.Add(new EnumField("fade function", "linear", "late", "very late", "early", "very early", "cosine", "zero", "one"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new AngleField("rotation:degrees"));
            this.Fields.Add(new RealField("pushback:world units"));
            this.Fields.Add(new RealBoundsField("jitter:world units"));
            this.Fields.Add(new ExplanationField("camera shaking", @"The wobble function and weight affects how the camera shake oscilates over time.
If the weight is one, then the wobble function completely scales the translational
and rotational magnitudes.  The less the weight, the less the effect wobble has.
If the wobble weight is 0 then wobble is completely ignored."));
            this.Fields.Add(new RealField("duration:seconds#the effect will last for this duration."));
            this.Fields.Add(new EnumField("falloff function#a function to envelope the effect\'s magnitude over time", "linear", "late", "very late", "early", "very early", "cosine", "zero", "one"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("random translation:world units#random translation in all directions"));
            this.Fields.Add(new AngleField("random rotation:degrees#random rotation in all directions"));
            this.Fields.Add(new EnumField("wobble function#a function to perturb the effect\'s behavior over time", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("wobble function period:seconds"));
            this.Fields.Add(new RealFractionField("wobble weight#a value of 0.0 signifies that the wobble function has no effect; a " +
                        "value of 1.0 signifies that the effect will not be felt when the wobble function" +
                        "\'s value is zero."));
            this.Fields.Add(new ExplanationField("sound", ""));
            this.Fields.Add(new TagReferenceField("sound", 1936614433));
            this.Fields.Add(new ExplanationField("breaking effect", @"Controls particle velocities when a damage effect shatters a materal.

All particles created within 'forward radius' will be kicked along the
damage direction with a speed equivalent to 'forward velocity' at the
epicenter of the damage and 0 at the outer radius.  'Forward exponent'
is used to modify the velocity scale.  A low exponent (like 0.5) means that
particles between the epicenter and the radius will be kicked out with a speed
closer to 'forward velocity' than if a higher exponent (like 2.0) was used

The outward fields work in a similar way, except instead of kicking along the
damage direction, they get kick away from the damage epicenter."));
            this.Fields.Add(new RealField("forward velocity:world units per second"));
            this.Fields.Add(new RealField("forward radius:world units"));
            this.Fields.Add(new RealField("forward exponent"));
            this.Fields.Add(new RealField("outward velocity:world units per second"));
            this.Fields.Add(new RealField("outward radius:world units"));
            this.Fields.Add(new RealField("outward exponent"));
        }
        /// <summary>
        /// Gets and returns the name of the damage_effect_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "damage_effect_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the damage_effect_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "damage_effect";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the damage_effect_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the damage_effect_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
