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
    /// Represents the generated scenario_weapons_resource (*eap) tag group.
    /// </summary>
    public class ScenarioWeaponsResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioWeaponsResource"/> class.
        /// </summary>
        public ScenarioWeaponsResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioWeaponsResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_weapons_resource tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "scenario_weapons_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_weapons_resource tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "*eap";
            }
        }
    }
}
