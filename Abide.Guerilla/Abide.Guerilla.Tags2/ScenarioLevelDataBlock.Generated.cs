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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(40, 4)]
    public class ScenarioLevelDataBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Level Description", typeof(TagReference))]
        public TagReference LevelDescription;
        [Abide.Guerilla.Tags.FieldAttribute("Campaign Level Data", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Global Ui Campaign Level Block", 20, typeof(GlobalUiCampaignLevelBlock))]
        public TagBlock CampaignLevelData;
        [Abide.Guerilla.Tags.FieldAttribute("Multiplayer", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Global Ui Multiplayer Level Block", 50, typeof(GlobalUiMultiplayerLevelBlock))]
        public TagBlock Multiplayer;
    }
}
#pragma warning restore CS1591