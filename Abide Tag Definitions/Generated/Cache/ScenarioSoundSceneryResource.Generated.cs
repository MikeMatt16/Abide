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
    /// Represents the generated scenario_sound_scenery_resource (*sce) tag group.
    /// </summary>
    public class ScenarioSoundSceneryResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioSoundSceneryResource"/> class.
        /// </summary>
        public ScenarioSoundSceneryResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioSoundSceneryResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_sound_scenery_resource tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "scenario_sound_scenery_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_sound_scenery_resource tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "*sce";
            }
        }
    }
}
