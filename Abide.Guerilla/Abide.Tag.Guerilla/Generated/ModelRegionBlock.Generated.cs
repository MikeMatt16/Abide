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
    /// Represents the generated model_region_block tag block.
    /// </summary>
    public sealed class ModelRegionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegionBlock"/> class.
        /// </summary>
        public ModelRegionBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new CharIntegerField("collision region index*"));
            this.Fields.Add(new CharIntegerField("physics region index*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ModelPermutationBlock>("permutations*", 32));
        }
        /// <summary>
        /// Gets and returns the name of the model_region_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "model_region_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_region_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "model_region_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_region_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_region_block tag block.
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
