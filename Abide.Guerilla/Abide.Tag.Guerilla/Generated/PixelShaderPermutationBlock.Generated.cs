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
    /// Represents the generated pixel_shader_permutation_block tag block.
    /// </summary>
    public sealed class PixelShaderPermutationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelShaderPermutationBlock"/> class.
        /// </summary>
        public PixelShaderPermutationBlock()
        {
            this.Fields.Add(new ShortIntegerField("enum index"));
            this.Fields.Add(new WordFlagsField("flags", "has final combiner"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("constants"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("combiners"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new SkipField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the pixel_shader_permutation_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "pixel_shader_permutation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pixel_shader_permutation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pixel_shader_permutation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pixel_shader_permutation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pixel_shader_permutation_block tag block.
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
