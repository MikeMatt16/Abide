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
    /// Represents the generated scenario_ai_resource (ai**) tag group.
    /// </summary>
    public class ScenarioAiResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioAiResource"/> class.
        /// </summary>
        public ScenarioAiResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioAiResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_ai_resource tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "scenario_ai_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_ai_resource tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "ai**";
            }
        }
    }
}
