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
    /// Represents the generated shader_template_property_block tag block.
    /// </summary>
    public sealed class ShaderTemplatePropertyBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTemplatePropertyBlock"/> class.
        /// </summary>
        public ShaderTemplatePropertyBlock()
        {
            this.Fields.Add(new EnumField("Property^", "Unused", "Diffuse Map", "Lightmap Emissive Map", "Lightmap Emissive Color", "Lightmap Emissive Power", "Lightmap Resolution Scale", "Lightmap Half Life", "Lightmap Diffuse Scale", "Lightmap Alpha Test Map", "Lightmap Translucent Map", "Lightmap Translucent Color", "Lightmap Translucent Alpha", "Active Camo Map", "Lightmap Foliage Scale"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringIdField("Parameter Name"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_template_property_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_template_property_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_template_property_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "property";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_template_property_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 14;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_template_property_block tag block.
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
