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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("ai_mission_dialogue", "mdlg", "����", typeof(AiMissionDialogueBlock))]
    public class AiMissionDialogueBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("lines", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Mission Dialogue Lines Block", 500, typeof(MissionDialogueLinesBlock))]
        public TagBlock Lines;
    }
}
#pragma warning restore CS1591
