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
    /// Represents the generated scenario_creature_resource (*rea) tag group.
    /// </summary>
    public class ScenarioCreatureResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioCreatureResource"/> class.
        /// </summary>
        public ScenarioCreatureResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioCreatureResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_creature_resource tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "scenario_creature_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_creature_resource tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "*rea";
            }
        }
    }
}
