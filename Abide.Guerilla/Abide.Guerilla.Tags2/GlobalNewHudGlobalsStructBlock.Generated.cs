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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(260, 4)]
    public class GlobalNewHudGlobalsStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("hud text", typeof(TagReference))]
        public TagReference HudText;
        [Abide.Guerilla.Tags.FieldAttribute("dashlights", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Hud Dashlights Block", 9, typeof(HudDashlightsBlock))]
        public TagBlock Dashlights;
        [Abide.Guerilla.Tags.FieldAttribute("waypoint arrows", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Hud Waypoint Arrow Block", 4, typeof(HudWaypointArrowBlock))]
        public TagBlock WaypointArrows;
        [Abide.Guerilla.Tags.FieldAttribute("waypoints", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Hud Waypoint Block", 8, typeof(HudWaypointBlock))]
        public TagBlock Waypoints;
        [Abide.Guerilla.Tags.FieldAttribute("hud sounds", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("New Hud Sound Block", 6, typeof(NewHudSoundBlock))]
        public TagBlock HudSounds;
        [Abide.Guerilla.Tags.FieldAttribute("player training data", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Player Training Entry Data Block", 32, typeof(PlayerTrainingEntryDataBlock))]
        public TagBlock PlayerTrainingData;
        [Abide.Guerilla.Tags.FieldAttribute("constants", typeof(GlobalNewHudGlobalsConstantsStructBlock))]
        public GlobalNewHudGlobalsConstantsStructBlock Constants;
    }
}
#pragma warning restore CS1591
