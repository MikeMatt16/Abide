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
    /// Represents the generated shader_pass_postprocess_definition_new_block tag block.
    /// </summary>
    public sealed class ShaderPassPostprocessDefinitionNewBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassPostprocessDefinitionNewBlock"/> class.
        /// </summary>
        public ShaderPassPostprocessDefinitionNewBlock()
        {
            this.Fields.Add(new BlockField<ShaderPassPostprocessImplementationNewBlock>("implementations", 1024));
            this.Fields.Add(new BlockField<ShaderPassPostprocessTextureNewBlock>("textures", 1024));
            this.Fields.Add(new BlockField<RenderStateBlock>("render states", 1024));
            this.Fields.Add(new BlockField<ShaderPassPostprocessTextureStateBlock>("texture states", 1024));
            this.Fields.Add(new BlockField<PixelShaderFragmentBlock>("ps fragments", 1024));
            this.Fields.Add(new BlockField<PixelShaderPermutationNewBlock>("ps permutations", 1024));
            this.Fields.Add(new BlockField<PixelShaderCombinerBlock>("ps combiners", 1024));
            this.Fields.Add(new BlockField<ShaderPassPostprocessExternNewBlock>("externs", 1024));
            this.Fields.Add(new BlockField<ShaderPassPostprocessConstantNewBlock>("constants", 1024));
            this.Fields.Add(new BlockField<ShaderPassPostprocessConstantInfoNewBlock>("constant info", 1024));
            this.Fields.Add(new BlockField<ShaderPassPostprocessImplementationBlock>("old implementations", 1024));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_postprocess_definition_new_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_pass_postprocess_definition_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_postprocess_definition_new_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_pass_postprocess_definition_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_postprocess_definition_new_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_postprocess_definition_new_block tag block.
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
