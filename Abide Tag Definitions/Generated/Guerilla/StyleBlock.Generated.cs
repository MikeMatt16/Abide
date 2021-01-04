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
    /// Represents the generated style_block tag block.
    /// </summary>
    public sealed class StyleBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StyleBlock"/> class.
        /// </summary>
        public StyleBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new ExplanationField("Combat status decay options", "Controls how combat status is allowed to be automatically reduced in the absence " +
                        "of combat stimuli. \'Latch at X\' means that once the level of x is attained (and/" +
                        "or surpassed) the combat status never falls below it"));
            this.Fields.Add(new EnumField("Combat status decay options", "Latch at Idle", "Latch at Alert", "Latch at Combat"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("Atittude", "Indicates general stance for style. This matches the property blocks in the chara" +
                        "cter definition (e.g. defense properties)"));
            this.Fields.Add(new EnumField("Attitude", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new CharEnumField("engage attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("evasion attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("cover attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("search attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("presearch attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("retreat attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("charge attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("ready attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("idle attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("weapon attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new CharEnumField("swarm attitude", "Default", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new ExplanationField("Style Behavior Control", "Check the appropriate box to turn on/off the given behavior"));
            this.Fields.Add(new LongFlagsField("Style control", "New behaviors default to ON"));
            this.Fields.Add(new LongFlagsField("Behaviors1", "------GENERAL------", "root", "null", "null_discrete", "obey", "guard", "follow behavior", "ready", "smash_obstacle", "destroy_obstacle", "perch", "cover_friend", "blind_panic", "------ENGAGE------", "engage", "fight", "melee_charge", "melee_leaping_charge", "surprise", "grenade_impulse", "anti_vehicle_grenade", "stalk", "berserk_wander_impulse", "------BERSERK------", "last_man_berserk", "stuck_with_grenade_berserk", "------PRESEARCH------", "presearch", "presearch uncover", "destroy_cover", "suppressing fire", "grenade_uncover"));
            this.Fields.Add(new LongFlagsField("Behaviors2", "leap_on_cover", "------SEARCH------", "search", "uncover", "investigate", "pursuit_sync", "pursuit", "postsearch", "coverme_investigate", "------SELF-DEFENSE------", "self_preservation", "cover", "cover peek", "avoid", "evasion_impulse", "dive_impulse", "danger cover impulse", "danger crouch impulse", "proximity_melee", "proximity_self_preservation", "unreachable_enemy_cover", "scary_target_cover", "group_emerge", "------RETREAT------", "retreat", "retreat_grenade", "flee", "cower", "low_shield_retreat", "scary_target_retreat", "leader_dead_retreat", "peer_dead_retreat"));
            this.Fields.Add(new LongFlagsField("Behaviors3", "danger_retreat", "proximity_retreat", "charge when cornered", "surprise_retreat", "overheated_weapon_retreat", "------AMBUSH------", "ambush", "coordinated_ambush", "proximity_ambush", "vulnerable_enemy_ambush", "nowhere_to_run_ambush", "------VEHICLE------", "vehicle", "enter_friendly_vehicle", "re-enter_flipped_vehicle", "vehicle_entry_engage_impulse", "vehicle_board", "vehicle_fight", "vehicle_charge", "vehicle_ram_behavior", "vehicle_cover", "damage_vehicle_cover", "exposed_rear_cover_impulse", "player_endagered_cover_impulse", "vehicle_avoid", "vehicle_pickup", "vehicle_player_pickup", "vehicle_exit_impulse", "danger_vehicle_exit_impulse", "vehicle_flip", "vehicle_turtle", "vehicle_engage_patrol_impulse"));
            this.Fields.Add(new LongFlagsField("Behaviors4", "vehicle_engage_wander_impulse", "------POSTCOMBAT------", "postcombat", "post_postcombat", "check_friend", "shoot_corpse", "postcombat_approach", "------ALERT------", "alert", "------IDLE------", "idle", "wander behavior", "flight_wander", "patrol", "fall_sleep", "------BUGGERS------", "bugger_ground_uncover", "------SWARMS------", "swarm_root", "swarm_attack", "support_attack", "infect", "scatter", "eject parasite", "flood_self_preservation", "juggernaut flurry", "------SENTINELS------", "enforcer weapon control", "grapple", "------SPECIAL------", "formation", "grunt scared by elite"));
            this.Fields.Add(new LongFlagsField("Behaviors5", "stunned", "cure_isolation", "deploy_turret", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""));
            this.Fields.Add(new BlockField<SpecialMovementBlock>("Special movement", 1));
            this.Fields.Add(new BlockField<BehaviorNamesBlock>("Behavior list", 160));
        }
        /// <summary>
        /// Gets and returns the name of the style_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "style_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the style_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "style";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the style_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the style_block tag block.
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
