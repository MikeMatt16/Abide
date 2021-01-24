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
    /// Represents the generated scenario_object_permutation_struct_block tag block.
    /// </summary>
    public sealed class ScenarioObjectPermutationStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioObjectPermutationStructBlock"/> class.
        /// </summary>
        public ScenarioObjectPermutationStructBlock()
        {
            this.Fields.Add(new StringIdField("Variant Name"));
            this.Fields.Add(new LongFlagsField("Active Change Colors", "Primary", "Secondary", "Tertiary", "Quaternary"));
            this.Fields.Add(new RgbColorField("Primary Color"));
            this.Fields.Add(new RgbColorField("Secondary Color"));
            this.Fields.Add(new RgbColorField("Tertiary Color"));
            this.Fields.Add(new RgbColorField("Quaternary Color"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_object_permutation_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_object_permutation_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_object_permutation_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_object_permutation_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_object_permutation_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_object_permutation_struct_block tag block.
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
