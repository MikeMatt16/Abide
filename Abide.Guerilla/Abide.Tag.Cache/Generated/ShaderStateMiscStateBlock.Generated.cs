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
    /// Represents the generated shader_state_misc_state_block tag block.
    /// </summary>
    public sealed class ShaderStateMiscStateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderStateMiscStateBlock"/> class.
        /// </summary>
        public ShaderStateMiscStateBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "YUV to RGB", "16-bit dither", "32-bit DXT1 noise"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RgbColorField("fog color"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_state_misc_state_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_state_misc_state_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_state_misc_state_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "misc state";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_state_misc_state_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_state_misc_state_block tag block.
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
