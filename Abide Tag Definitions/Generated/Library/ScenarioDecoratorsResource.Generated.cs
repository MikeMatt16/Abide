//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated scenario_decorators_resource (dc*s) tag group.
    /// </summary>
    public class ScenarioDecoratorsResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioDecoratorsResource"/> class.
        /// </summary>
        public ScenarioDecoratorsResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioDecoratorsResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_decorators_resource tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "scenario_decorators_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_decorators_resource tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "dc*s";
            }
        }
    }
}
