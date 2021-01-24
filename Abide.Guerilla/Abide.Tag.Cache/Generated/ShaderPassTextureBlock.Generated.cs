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
    /// Represents the generated shader_pass_texture_block tag block.
    /// </summary>
    public sealed class ShaderPassTextureBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassTextureBlock"/> class.
        /// </summary>
        public ShaderPassTextureBlock()
        {
            this.Fields.Add(new StringIdField("Source Parameter"));
            this.Fields.Add(new EnumField("Source Extern", "None", "GLOBAL: Vector Normalization", "UNUSED", "GLOBAL: Target texaccum", "UNUSED", "GLOBAL: Target Frame Buffer", "GLOBA: Target z", "UNUSED", "GLOBAL: Target Shadow", "LIGHT: Falloff", "LIGHT: Gel", "LIGHTMAP", "UNUSED", "GLOBAL: Shadow Buffer", "GLOBAL: Gradient Separate", "GLOBAL: Gradient Product", "HUD: Bitmap", "GLOBAL: active camo", "GLOBAL: Texture Camera", "GLOBAL: Water Reflection", "GLOBAL: Water Refraction", "GLOBAL: Aux 1", "GLOBAL: Aux 2", "GLOBAL: Particle Distortion", "GLOBAL: Convolution 1", "GLOBAL: Convolution 2", "SHADER: Active Camo Bump", "FIRST PERSON: Scope"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new EnumField("Mode", "2D", "3D", "Cube Map", "Passthrough", "texkill", "2D Dependent AR", "2D Dependent GB", "2D bumpenv", "2D bumpenv Luminance", "3D BRDF", "Dot Product", "Dot Product 2D", "Dot Product 3D", "Dot Product Cube Map", "Dot Product ZW", "Dot Reflect Diffuse", "Dot Reflect Specular", "Dot Reflect Specular Const", "None"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("Dot Mapping", "0 to 1", "Signed D3D", "Signed GL", "Signed NV", "HILO: 0 to 1", "HILO: Signed Hemisphere D3D", "HILO: Signed Hemisphere GL", "HILO: Signed Hemisphere NV"));
            this.Fields.Add(new ShortIntegerField("Input Stage:[0,3]"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ShaderTextureStateAddressStateBlock>("address state", 1));
            this.Fields.Add(new BlockField<ShaderTextureStateFilterStateBlock>("filter state", 1));
            this.Fields.Add(new BlockField<ShaderTextureStateKillStateBlock>("kill state", 1));
            this.Fields.Add(new BlockField<ShaderTextureStateMiscStateBlock>("misc state", 1));
            this.Fields.Add(new BlockField<ShaderTextureStateConstantBlock>("constants", 10));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_texture_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_pass_texture_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_texture_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "texture stage";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_texture_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_texture_block tag block.
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
