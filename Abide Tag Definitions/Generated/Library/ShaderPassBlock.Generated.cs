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
    /// Represents the generated shader_pass_block tag block.
    /// </summary>
    public sealed class ShaderPassBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassBlock"/> class.
        /// </summary>
        public ShaderPassBlock()
        {
            this.Fields.Add(new DataField("Documentation", 1, 4));
            this.Fields.Add(new BlockField<ShaderPassParameterBlock>("Parameters", 64));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ShaderPassImplementationBlock>("Implementations", 32));
            this.Fields.Add(new BlockField<ShaderPassPostprocessDefinitionNewBlock>("Postprocess Definition*", 1));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_pass_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_pass";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_block tag block.
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
