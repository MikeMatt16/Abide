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
    /// Represents the generated rasterizer_screen_effect_pass_reference_block tag block.
    /// </summary>
    public sealed class RasterizerScreenEffectPassReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RasterizerScreenEffectPassReferenceBlock"/> class.
        /// </summary>
        public RasterizerScreenEffectPassReferenceBlock()
        {
            this.Fields.Add(new DataField("explanation", 1, 4));
            this.Fields.Add(new ExplanationField("IMPLEMENTATIONS", "Used to control which shader pass implementations are used depending on whether t" +
                        "he primary and/or secondary external inputs are greater than zero. An implementa" +
                        "tion of -1 will not draw anything."));
            this.Fields.Add(new ShortIntegerField("layer pass index*:leave as -1 unless debugging"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new CharIntegerField("primary=0 and secondary=0:implementation index"));
            this.Fields.Add(new CharIntegerField("primary>0 and secondary=0:implementation index"));
            this.Fields.Add(new CharIntegerField("primary=0 and secondary>0:implementation index"));
            this.Fields.Add(new CharIntegerField("primary>0 and secondary>0:implementation index"));
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new ExplanationField("TEXCOORD GENERATION", @"* DEFAULT: Use for mask bitmaps that are mirrored and offset through the texcoords supplied to the screen effect (e.g. through the weapon HUD interface). The shader system must handle scaling.

* VIEWPORT NORMALIZED: Use when copying from texaccum or some other buffer or when applying a texture that is not an interface mask (e.g. another kind of mask, a noise map, etc. which is not mirrored or offset through the weapon HUD interface). Texture coordinates will range from [0,1][0,1] within the viewport, and the shader system must handle scaling if the bitmap is a linear target or an interface bitmap.

* VIEWPORT RELATIVE: Should not be used! This mode was necessary before we had he ability for the shader system to scale by texture resolution. Texture coordinates will range from [0,viewport_size_x][0,viewport_size_y] within the viewport.

* FRAMEBUFFER RELATIVE: Use when copying from the framebuffer. Texture coordinates will range from [viewport_bounds.x0,viewport_bounds.x1][viewport_bounds.y0,viewport_bounds.y1] within the viewport. Let the shader system assume normalized [0,1] coordinate range.

* ZERO: Use when doing dependent-z reads. Texture coordinates will be zero before applying offset (in advanced control block). Offset should be {1/(z_max-z_min), 0, -z_min/(z_max-z_min), 0} where z_min and z_max are in world units, and the ""xy scaled by z_far"" flag should be checked."));
            this.Fields.Add(new EnumField("stage 0 mode", "default", "viewport normalized", "viewport relative", "framebuffer relative", "zero"));
            this.Fields.Add(new EnumField("stage 1 mode", "default", "viewport normalized", "viewport relative", "framebuffer relative", "zero"));
            this.Fields.Add(new EnumField("stage 2 mode", "default", "viewport normalized", "viewport relative", "framebuffer relative", "zero"));
            this.Fields.Add(new EnumField("stage 3 mode", "default", "viewport normalized", "viewport relative", "framebuffer relative", "zero"));
            this.Fields.Add(new BlockField<RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock>("advanced control", 1));
            this.Fields.Add(new ExplanationField("TARGET", ""));
            this.Fields.Add(new EnumField("target", "framebuffer", "texaccum", "texaccum small", "texaccum tiny", "copy fb to texaccum"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new BlockField<RasterizerScreenEffectConvolutionBlock>("convolution", 2));
        }
        /// <summary>
        /// Gets and returns the name of the rasterizer_screen_effect_pass_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "rasterizer_screen_effect_pass_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the rasterizer_screen_effect_pass_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pass reference";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the rasterizer_screen_effect_pass_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the rasterizer_screen_effect_pass_reference_block tag block.
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
