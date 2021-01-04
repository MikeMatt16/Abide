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
    /// Represents the generated pixel_shader_fragment_block tag block.
    /// </summary>
    public sealed class PixelShaderFragmentBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelShaderFragmentBlock"/> class.
        /// </summary>
        public PixelShaderFragmentBlock()
        {
            this.Fields.Add(new CharIntegerField("switch parameter index"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("permutations index"));
        }
        /// <summary>
        /// Gets and returns the name of the pixel_shader_fragment_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "pixel_shader_fragment_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pixel_shader_fragment_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pixel_shader_fragment_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pixel_shader_fragment_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pixel_shader_fragment_block tag block.
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
