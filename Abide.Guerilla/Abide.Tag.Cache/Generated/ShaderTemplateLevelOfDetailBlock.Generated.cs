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
    /// Represents the generated shader_template_level_of_detail_block tag block.
    /// </summary>
    public sealed class ShaderTemplateLevelOfDetailBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTemplateLevelOfDetailBlock"/> class.
        /// </summary>
        public ShaderTemplateLevelOfDetailBlock()
        {
            this.Fields.Add(new RealField("Projected Diameter:pixels"));
            this.Fields.Add(new BlockField<ShaderTemplatePassReferenceBlock>("Pass", 16));
        }
        /// <summary>
        /// Gets and returns the name of the shader_template_level_of_detail_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_template_level_of_detail_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_template_level_of_detail_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_template_level_of_detail_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_template_level_of_detail_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_template_level_of_detail_block tag block.
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
