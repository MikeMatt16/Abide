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
    /// Represents the generated character_vehicle_block tag block.
    /// </summary>
    public sealed class CharacterVehicleBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterVehicleBlock"/> class.
        /// </summary>
        public CharacterVehicleBlock()
        {
            this.Fields.Add(new TagReferenceField("unit^", 1970170228));
            this.Fields.Add(new TagReferenceField("style^", 1937013100));
            this.Fields.Add(new LongFlagsField("vehicle flags", "passengers adopt original squad"));
            this.Fields.Add(new ExplanationField("Pathfinding", ""));
            this.Fields.Add(new RealField("ai pathfinding radius:world units#(Ground vehicles)"));
            this.Fields.Add(new RealField("ai destination radius:world units#(All vehicles) Distance within which goal is co" +
                        "nsidered reached"));
            this.Fields.Add(new RealField("ai deceleration distanceworld units#(All vehicles)Distance from goal at which AI " +
                        "starts to decelerate"));
            this.Fields.Add(new ExplanationField("Turning", ""));
            this.Fields.Add(new RealField("ai turning radius#(Warthog, Pelican, Ghost) Idealized average turning radius (sho" +
                        "uld reflect actual vehicle physics)"));
            this.Fields.Add(new RealField("ai inner turning radius (< tr)#(Warthog-type) Idealized minimum turning radius (s" +
                        "hould reflect actual vehicle physics)"));
            this.Fields.Add(new RealField("ai ideal turning radius (> tr)#(Warthogs, ghosts) Ideal turning radius for roundi" +
                        "ng turns (barring obstacles, etc.)"));
            this.Fields.Add(new ExplanationField("Steering", ""));
            this.Fields.Add(new AngleField("ai banshee steering maximum#(Banshee)"));
            this.Fields.Add(new RealField("ai max steering angle:degrees#(Warthog, ghosts, wraiths)Maximum steering angle fr" +
                        "om forward (ultimately controls turning speed)"));
            this.Fields.Add(new RealField("ai max steering delta: degrees#(pelicans, dropships, ghosts, wraiths)Maximum delt" +
                        "a in steering angle from one tick to the next (ultimately controls turn accelera" +
                        "tion)"));
            this.Fields.Add(new RealField("ai oversteering scale#(Warthog, ghosts, wraiths)"));
            this.Fields.Add(new AngleBoundsField("ai oversteering bounds#(Banshee) Angle to goal at which AI will oversteer"));
            this.Fields.Add(new RealField("ai sideslip distance#(Ghosts, Dropships) Distance within which Ai will strafe to " +
                        "target (as opposed to turning)"));
            this.Fields.Add(new RealField("ai avoidance distance:world units#(Banshee-style) Look-ahead distance for obstacl" +
                        "e avoidance"));
            this.Fields.Add(new RealField("ai min urgency:[0-1]#(Banshees)The minimum urgency with which a turn can be made " +
                        "(urgency = percent of maximum steering delta)"));
            this.Fields.Add(new ExplanationField("Throttle", ""));
            this.Fields.Add(new RealField("ai throttle maximum:(0 - 1)#(All vehicles)"));
            this.Fields.Add(new RealField("ai goal min throttle scale#(Warthogs, Dropships, ghosts)scale on throttle when wi" +
                        "thin \'ai deceleration distance\' of goal (0...1)"));
            this.Fields.Add(new RealField("ai turn min throttle scale#(Warthogs, ghosts) Scale on throttle due to nearness t" +
                        "o a turn (0...1)"));
            this.Fields.Add(new RealField("ai direction min throttle scale#(Warthogs, ghosts) Scale on throttle due to facin" +
                        "g away from intended direction (0...1)"));
            this.Fields.Add(new RealField("ai acceleration scale:(0-1)#(warthogs, ghosts) The maximum allowable change in th" +
                        "rottle between ticks"));
            this.Fields.Add(new RealField("ai throttle blend:(0-1)#(dropships, sentinels) The degree of throttle blending be" +
                        "tween one tick and the next (0 = no blending)"));
            this.Fields.Add(new RealField("theoretical max speed:wu/s#(dropships, warthogs, ghosts) About how fast I can go." +
                        ""));
            this.Fields.Add(new RealField("error scale#(dropships, warthogs) scale on the difference between desired and act" +
                        "ual speed, applied to throttle"));
            this.Fields.Add(new ExplanationField("Combat", ""));
            this.Fields.Add(new AngleField("ai allowable aim deviation angle"));
            this.Fields.Add(new ExplanationField("Behavior", ""));
            this.Fields.Add(new RealField("ai charge tight angle distance#(All vehicles) The distance at which the tight ang" +
                        "le criterion is used for deciding to vehicle charge"));
            this.Fields.Add(new RealField("ai charge tight angle:[0-1]#(All vehicles) Angle cosine within which the target m" +
                        "ust be when target is closer than tight angle distance in order to charge"));
            this.Fields.Add(new RealField("ai charge repeat timeout#(All vehicles) Time delay between vehicle charges"));
            this.Fields.Add(new RealField("ai charge look-ahead time#(All vehicles) In deciding when to abort vehicle charge" +
                        ", look ahead these many seconds to predict time of contact"));
            this.Fields.Add(new RealField("ai charge consider distance#Consider charging the target when it is within this r" +
                        "ange (0 = infinite distance)"));
            this.Fields.Add(new RealField("ai charge abort distance#Abort the charge when the target get more than this far " +
                        "away (0 = never abort)"));
            this.Fields.Add(new RealField("vehicle ram timeout#The ram behavior stops after a maximum of the given number of" +
                        " seconds"));
            this.Fields.Add(new RealField("ram paralysis time#The ram behavior freezes the vehicle for a given number of sec" +
                        "onds after performing the ram"));
            this.Fields.Add(new RealField("ai cover damage threshold#(All vehicles) Trigger a cover when recent damage is ab" +
                        "ove given threshold (damage_vehicle_cover impulse)"));
            this.Fields.Add(new RealField("ai cover min distance#(All vehicles) When executing vehicle-cover, minimum distan" +
                        "ce from the target to flee to"));
            this.Fields.Add(new RealField("ai cover time#(All vehicles) How long to stay away from the target"));
            this.Fields.Add(new RealField("ai cover min boost distance#(All vehicles) Boosting allowed when distance to cove" +
                        "r destination is greater then this."));
            this.Fields.Add(new RealField("turtling recent damage threshold:%#If vehicle turtling behavior is enabled, turtl" +
                        "ing is initiated if \'recent damage\' surpasses the given threshold"));
            this.Fields.Add(new RealField("turtling min time:seconds#If the vehicle turtling behavior is enabled, turtling o" +
                        "ccurs for at least the given time"));
            this.Fields.Add(new RealField("turtling timeout:seconds#The turtled state times out after the given number of se" +
                        "conds"));
            this.Fields.Add(new EnumField("obstacle ignore size", "none", "tiny", "small", "medium", "large", "huge", "immobile"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the character_vehicle_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "character_vehicle_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_vehicle_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_vehicle_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_vehicle_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_vehicle_block tag block.
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
