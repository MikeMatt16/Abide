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
    /// Represents the generated scenario_sky_reference_block tag block.
    /// </summary>
    public sealed class ScenarioSkyReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioSkyReferenceBlock"/> class.
        /// </summary>
        public ScenarioSkyReferenceBlock()
        {
            this.Fields.Add(new TagReferenceField("Sky", 1936423200));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_sky_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_sky_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_sky_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_sky_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_sky_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_sky_reference_block tag block.
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
