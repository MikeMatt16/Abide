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
    /// Represents the generated shader_state_fill_state_block tag block.
    /// </summary>
    public sealed class ShaderStateFillStateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderStateFillStateBlock"/> class.
        /// </summary>
        public ShaderStateFillStateBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "flat shading", "edge antialiasing"));
            this.Fields.Add(new EnumField("fill mode", "solid", "wireframe", "points"));
            this.Fields.Add(new EnumField("back fill mode", "solid", "wireframe", "points"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("line width"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_state_fill_state_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_state_fill_state_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_state_fill_state_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "fill state";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_state_fill_state_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_state_fill_state_block tag block.
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
