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
    /// Represents the generated dont_use_me_scenario_environment_object_block tag block.
    /// </summary>
    public sealed class DontUseMeScenarioEnvironmentObjectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DontUseMeScenarioEnvironmentObjectBlock"/> class.
        /// </summary>
        public DontUseMeScenarioEnvironmentObjectBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("BSP*"));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new LongIntegerField("Unique ID*"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new TagField("Object Definition Tag*"));
            this.Fields.Add(new LongIntegerField("Object*^"));
            this.Fields.Add(new PadField("", 44));
        }
        /// <summary>
        /// Gets and returns the name of the dont_use_me_scenario_environment_object_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "dont_use_me_scenario_environment_object_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the dont_use_me_scenario_environment_object_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "dont_use_me_scenario_environment_object_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the dont_use_me_scenario_environment_object_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4096;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the dont_use_me_scenario_environment_object_block tag block.
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
