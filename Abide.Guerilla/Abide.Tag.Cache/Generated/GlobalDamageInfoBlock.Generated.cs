//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated global_damage_info_block tag block.
    /// </summary>
    public sealed class GlobalDamageInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalDamageInfoBlock"/> class.
        /// </summary>
        public GlobalDamageInfoBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "takes shield damage for children", "takes body damage for children", "always shields friendly damage", "passes area damage to children", "parent never takes body damage for us", "only damaged by explosives", "parent never takes shield damage for us", "cannot die from damage", "passes attached damage to riders"));
            this.Fields.Add(new StringIdField("global indirect material name#absorbes AOE or child damage"));
            this.Fields.Add(new ShortBlockIndexField("indirect damage section#absorbes AOE or child damage"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new CharEnumField("collision damage reporting type", "teh guardians!!1!!1!", "falling damage", "generic collision damage", "generic melee damage", "generic explosion", "magnum pistol", "plasma pistol", "needler", "smg", "plasma rifle", "battle rifle", "carbine", "shotgun", "sniper rifle", "beam rifle", "rocket launcher", "flak cannon", "brute shot", "disintegrator", "brute plasma rifle", "energy sword", "frag grenade", "plasma grenade", "flag melee damage", "bomb melee damage", "bomb explosion damage", "ball melee damage", "human turret", "plasma turret", "banshee", "ghost", "mongoose", "scorpion", "spectre driver", "spectre gunner", "warthog driver", "warthog gunner", "wraith", "tank", "sentinel beam", "sentinel rpg", "teleporter"));
            this.Fields.Add(new CharEnumField("response damage reporting type", "teh guardians!!1!!1!", "falling damage", "generic collision damage", "generic melee damage", "generic explosion", "magnum pistol", "plasma pistol", "needler", "smg", "plasma rifle", "battle rifle", "carbine", "shotgun", "sniper rifle", "beam rifle", "rocket launcher", "flak cannon", "brute shot", "disintegrator", "brute plasma rifle", "energy sword", "frag grenade", "plasma grenade", "flag melee damage", "bomb melee damage", "bomb explosion damage", "ball melee damage", "human turret", "plasma turret", "banshee", "ghost", "mongoose", "scorpion", "spectre driver", "spectre gunner", "warthog driver", "warthog gunner", "wraith", "tank", "sentinel beam", "sentinel rpg", "teleporter"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new ExplanationField("body", ""));
            this.Fields.Add(new RealField("maximum vitality"));
            this.Fields.Add(new RealField("minimum stun damage#the minimum damage required to stun this object\'s health"));
            this.Fields.Add(new RealField("stun time:seconds#the length of time the health stay stunned (do not recharge) af" +
                        "ter taking damage"));
            this.Fields.Add(new RealField("recharge time:seconds#the length of time it would take for the shields to fully r" +
                        "echarge after being completely depleted"));
            this.Fields.Add(new RealFractionField("recharge fraction#0 defaults to 1 - to what maximum level the body health will be" +
                        " allowed to recharge"));
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new ExplanationField("shield", ""));
            this.Fields.Add(new TagReferenceField("shield damaged first person shader", 1936220516));
            this.Fields.Add(new TagReferenceField("shield damaged shader", 1936220516));
            this.Fields.Add(new RealField("maximum shield vitality#the default initial and maximum shield vitality of this o" +
                        "bject"));
            this.Fields.Add(new StringIdField("global shield material name"));
            this.Fields.Add(new RealField("minimum stun damage#the minimum damage required to stun this object\'s shields"));
            this.Fields.Add(new RealField("stun time:seconds#the length of time the shields stay stunned (do not recharge) a" +
                        "fter taking damage"));
            this.Fields.Add(new RealField("recharge time:seconds#the length of time it would take for the shields to fully r" +
                        "echarge after being completely depleted"));
            this.Fields.Add(new RealField("shield damaged threshold"));
            this.Fields.Add(new TagReferenceField("shield damaged effect", 1701209701));
            this.Fields.Add(new TagReferenceField("shield depleted effect", 1701209701));
            this.Fields.Add(new TagReferenceField("shield recharging effect", 1701209701));
            this.Fields.Add(new BlockField<GlobalDamageSectionBlock>("damage sections", 16));
            this.Fields.Add(new BlockField<GlobalDamageNodesBlock>("nodes*", 255));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new BlockField<DamageSeatInfoBlock>("damage seats", 16));
            this.Fields.Add(new BlockField<DamageConstraintInfoBlock>("damage constraints", 16));
            this.Fields.Add(new ExplanationField("overshield", ""));
            this.Fields.Add(new TagReferenceField("overshield first person shader", 1936220516));
            this.Fields.Add(new TagReferenceField("overshield shader", 1936220516));
        }
        /// <summary>
        /// Gets and returns the name of the global_damage_info_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_damage_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_damage_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_damage_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_damage_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_damage_info_block tag block.
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
