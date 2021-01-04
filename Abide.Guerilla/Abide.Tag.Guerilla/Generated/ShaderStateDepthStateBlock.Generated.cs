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
    /// Represents the generated shader_state_depth_state_block tag block.
    /// </summary>
    public sealed class ShaderStateDepthStateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderStateDepthStateBlock"/> class.
        /// </summary>
        public ShaderStateDepthStateBlock()
        {
            this.Fields.Add(new EnumField("mode", "use Z", "use W"));
            this.Fields.Add(new EnumField("depth compare function", "never", "less", "equal", "less or equal", "greater", "not equal", "greater or equal", "always"));
            this.Fields.Add(new WordFlagsField("flags", "depth write", "offset points", "offset lines", "offset triangles", "clip control don\'t cull primitive", "clip control clamp", "clip control ignore W sign"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("depth bias slope scale"));
            this.Fields.Add(new RealField("depth bias"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_state_depth_state_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_state_depth_state_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_state_depth_state_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "depth state";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_state_depth_state_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_state_depth_state_block tag block.
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
