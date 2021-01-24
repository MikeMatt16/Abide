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
    /// Represents the generated shader_texture_state_constant_block tag block.
    /// </summary>
    public sealed class ShaderTextureStateConstantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTextureStateConstantBlock"/> class.
        /// </summary>
        public ShaderTextureStateConstantBlock()
        {
            this.Fields.Add(new StringIdField("source parameter"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("constant^", "mipmap bias (value)", "colorkey color", "border color", "border alpha (value)", "bumpenv mat[0][0]", "bumpenv mat[0][1]", "bumpenv mat[1][0]", "bumpenv mat[1][1]", "bumpenv lum scale (value)", "bumpenv lum offset (value)"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_texture_state_constant_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_texture_state_constant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_texture_state_constant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "texture constant";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_texture_state_constant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 10;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_texture_state_constant_block tag block.
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
