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
    /// Represents the generated ai_scenario_mission_dialogue_block tag block.
    /// </summary>
    public sealed class AiScenarioMissionDialogueBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiScenarioMissionDialogueBlock"/> class.
        /// </summary>
        public AiScenarioMissionDialogueBlock()
        {
            this.Fields.Add(new TagReferenceField("mission dialogue", 1835297895));
        }
        /// <summary>
        /// Gets and returns the name of the ai_scenario_mission_dialogue_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ai_scenario_mission_dialogue_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_scenario_mission_dialogue_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_scenario_mission_dialogue_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_scenario_mission_dialogue_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_scenario_mission_dialogue_block tag block.
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
