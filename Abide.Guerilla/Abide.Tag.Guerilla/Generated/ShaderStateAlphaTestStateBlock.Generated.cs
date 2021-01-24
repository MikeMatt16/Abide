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
    /// Represents the generated shader_state_alpha_test_state_block tag block.
    /// </summary>
    public sealed class ShaderStateAlphaTestStateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderStateAlphaTestStateBlock"/> class.
        /// </summary>
        public ShaderStateAlphaTestStateBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "alpha-test enabled", "sample-alpha to coverage", "sample-alpha to one"));
            this.Fields.Add(new EnumField("alpha compare function", "never", "less", "equal", "less or equal", "greater", "not equal", "greater or equal", "always"));
            this.Fields.Add(new ShortIntegerField("alpha-test ref:[0,255]"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the shader_state_alpha_test_state_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_state_alpha_test_state_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_state_alpha_test_state_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "alpha-test state";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_state_alpha_test_state_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_state_alpha_test_state_block tag block.
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
