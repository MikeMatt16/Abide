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
    /// Represents the generated shader_pass_parameter_block tag block.
    /// </summary>
    public sealed class ShaderPassParameterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassParameterBlock"/> class.
        /// </summary>
        public ShaderPassParameterBlock()
        {
            this.Fields.Add(new StringIdField("Name^"));
            this.Fields.Add(new DataField("Explanation", 1, 4));
            this.Fields.Add(new EnumField("Type", "Bitmap", "Value", "Color", "Switch"));
            this.Fields.Add(new WordFlagsField("Flags", "No Bitmap LOD", "Required Parameter"));
            this.Fields.Add(new TagReferenceField("Default Bitmap", 1651078253));
            this.Fields.Add(new RealField("Default Const Value"));
            this.Fields.Add(new RealRgbColorField("Default Const Color"));
            this.Fields.Add(new EnumField("Source Extern", "None", "GLOBAL: Eye Forward Vector (z)", "GLOBAL: Eye Right Vector (x)", "GLOBAL: Eye Up Vector (y)", "OBJECT: Primary Color", "OBJECT: Secondary Color", "OBJECT: Function Value", "LIGHT: Diffuse Color", "LIGHT: Specular Color", "LIGHT: Forward Vector (z)", "LIGHT: Right Vector (x)", "LIGHT: Up Vector (y)", "LIGHT: Object-Relative Forward Vector (z)", "LIGHT: Object-Relative Right Vector (x)", "LIGHT: Object-Relative Up Vector (y)", "LIGHT: Object Falloff Value", "LIGHT: Object Gel Color", "LIGHTMAP: Object Ambient Factor", "LIGHTMAP: Object Direct Vector", "LIGHTMAP: Object Direct Color", "LIGHTMAP: Object Indirect Vector", "LIGHTMAP: Object Indirect Color", "OLD FOG: Atmospheric Color", "OLD FOG: Atmospheric Max Density", "OLD FOG: Planar Color", "OLD FOG: Planar Max Density", "OLD FOG: Atmospheric Planar Blend Value", "OLD FOG: Object Atmospheric Density", "OLD FOG: Object Planar Density", "OLD FOG: Object Color", "OLD FOG: Object Density", "OBJECT: Model Alpha", "OBJECT: Shadow Alpha", "LIGHT: Overbrighten Diffuse Shift", "LIGHT: Overbrighten Specular Shift", "LIGHT: Diffuse Contrast", "LIGHT: Specular Gel", "SHADER: Specular Type", "pad3", "pad3-scale", "Pad Thai", "Taco Salad", "Anisotropic Binormal", "OBJECT LIGHT: Shadow Fade", "LIGHT: Shadow Fade", "OLD FOG: Atmospheric Density", "OLD FOG: Planar Density", "OLD FOG: Planar Density Invert", "OBJECT: Change Color Tertiary", "OBJECT: Change Color Quaternary", "LIGHTMAP: Object Specular Color", "SHADER: Lightmap Type", "LIGHTMAP: Object Ambient Color", "SHADER: Lightmap Specular Brightness", "GLOBAL: Lightmap Shadow Darkening", "LIGHTMAP: Object Env Brightness", "FOG: Atmospheric Max Density", "FOG: Atmospheric Color", "FOG: Atmospheric Color Adj", "FOG: Atmospheric Planar Blend", "FOG: Atmospheric Planar Blend Adj Inv", "FOG: Atmospheric Planar Blend Adj", "FOG: Secondary Max Density", "FOG: Secondary Color", "FOG: Secondary Color Adj", "FOG: Atmospheric Secondary Blend", "FOG: Atmospheric Secondary Blend Adj Inv", "FOG: Atmospheric Secondary Blend Adj", "FOG: Sky Density", "FOG: Sky Color", "FOG: Sky Color Adj", "FOG: Planar Max Density", "FOG: Planar Color", "FOG: Planar Color Adj", "FOG: Planar Eye Density", "FOG: Planar Eye Density Adj Inv", "FOG: Planar Eye Density Adj", "HUD: Waypoint Primary Color", "HUD: Waypoint Secondary Color", "LIGHTMAP: Object Specular Color Times One Half", "LIGHT: Specular Enabled", "LIGHT: Definition Specular Enabled", "OBJECT: Active Camo Amount", "OBJECT: Super Camo Amount", "HUD: Custom Color 1", "HUD: Custom Color 2", "HUD: Custom Color 3", "HUD: Custom Color 4", "OBJECT: Active Camo RGB", "FOG: Patchy Plane n(xyz)", "FOG: Patchy Plane d(w)", "HUD: Global Fade", "SCREEN EFFECT: Primary", "SCREEN EFFECT: Secondary"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_parameter_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_pass_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_parameter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "parameter";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_parameter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_parameter_block tag block.
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
