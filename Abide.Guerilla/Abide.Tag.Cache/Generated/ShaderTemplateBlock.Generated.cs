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
    /// Represents the generated shader_template_block tag block.
    /// </summary>
    public sealed class ShaderTemplateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTemplateBlock"/> class.
        /// </summary>
        public ShaderTemplateBlock()
        {
            this.Fields.Add(new DataField("Documentation", 1, 4));
            this.Fields.Add(new StringIdField("Default Material Name"));
            this.Fields.Add(new ExplanationField("FLAGS", "* Force Active Camo: Should be used with cautuion, as this causes a backbuffer co" +
                        "py when this shader is rendered.\n* Water: ???.\n* Foliage: Used with lightmapped " +
                        "foliage (two-sided lighting) shaders. It affects importing but not rendering."));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new WordFlagsField("Flags", "Force Active Camo", "Water", "Foliage", "Hide Standard Parameters"));
            this.Fields.Add(new BlockField<ShaderTemplatePropertyBlock>("Properties", 14));
            this.Fields.Add(new BlockField<ShaderTemplateCategoryBlock>("Categories", 16));
            this.Fields.Add(new ExplanationField("LIGHT RESPONSE", "Not used anymore."));
            this.Fields.Add(new TagReferenceField("Light Response", 1936484724));
            this.Fields.Add(new BlockField<ShaderTemplateLevelOfDetailBlock>("LODs", 8));
            this.Fields.Add(new BlockField<ShaderTemplateRuntimeExternalLightResponseIndexBlock>("", 65535));
            this.Fields.Add(new BlockField<ShaderTemplateRuntimeExternalLightResponseIndexBlock>("", 65535));
            this.Fields.Add(new ExplanationField("RECURSIVE RENDERING", "Really cool stuff."));
            this.Fields.Add(new TagReferenceField("Aux 1 Shader", 1936220516));
            this.Fields.Add(new EnumField("Aux 1 Layer", "texaccum", "Environment Map", "Self-Illumination", "Overlay", "Transparent", "Lightmap (Indirect)", "Diffuse", "Specular", "Shadow Generate", "Shadow Apply", "Boom", "Fog", "Sh Prt", "Active Camo", "Water Edge Blend", "Decal", "Active Camo Stencil Modulate", "Hologram", "Light Albedo"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("Aux 2 Shader", 1936220516));
            this.Fields.Add(new EnumField("Aux 2 Layer", "texaccum", "Environment Map", "Self-Illumination", "Overlay", "Transparent", "Lightmap (Indirect)", "Diffuse", "Specular", "Shadow Generate", "Shadow Apply", "Boom", "Fog", "Sh Prt", "Active Camo", "Water Edge Blend", "Decal", "Active Camo Stencil Modulate", "Hologram", "Light Albedo"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ShaderTemplatePostprocessDefinitionNewBlock>("Postprocess Definition*", 1));
        }
        /// <summary>
        /// Gets and returns the name of the shader_template_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_template_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_template_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_template";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_template_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_template_block tag block.
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
