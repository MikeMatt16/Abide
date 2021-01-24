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
    /// Represents the generated lens_flare_block tag block.
    /// </summary>
    public sealed class LensFlareBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LensFlareBlock"/> class.
        /// </summary>
        public LensFlareBlock()
        {
            this.Fields.Add(new ExplanationField("LENS FLARE", ""));
            this.Fields.Add(new AngleField("falloff angle:degrees"));
            this.Fields.Add(new AngleField("cutoff angle:degrees"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new ExplanationField("OCCLUSION", "Occlusion factor affects overall lens flare brightness and can also affect scale." +
                        " Occlusion never affects rotation."));
            this.Fields.Add(new RealField("occlusion radius:world units#radius of the square used to test occlusion"));
            this.Fields.Add(new EnumField("occlusion offset direction", "toward viewer", "marker forward", "none"));
            this.Fields.Add(new EnumField("occlusion inner radius scale", "none", "1/2", "1/4", "1/8", "1/16", "1/32", "1/64"));
            this.Fields.Add(new RealField("near fade distance:world units#distance at which the lens flare brightness is max" +
                        "imum"));
            this.Fields.Add(new RealField("far fade distance:world units#distance at which the lens flare brightness is mini" +
                        "mum; set to zero to disable distance fading"));
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
            this.Fields.Add(new WordFlagsField("flags", "sun", "no occlusion test", "only render in first person", "only render in third person", "fade in more quickly", "fade out more quickly", "scale by marker"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new EnumField("rotation function", "none", "rotation A", "rotation B", "rotation-translation", "translation"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new AngleField("rotation function scale:degrees"));
            this.Fields.Add(new RealVector2dField("corona scale#amount to stretch the corona"));
            this.Fields.Add(new ExplanationField("EFFECT PARAMETERS", "Only affects lens flares created by effects."));
            this.Fields.Add(new EnumField("falloff function", "linear", "late", "very late", "early", "very early", "cosine", "zero", "one"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<LensFlareReflectionBlock>("reflections", 32));
            this.Fields.Add(new ExplanationField("ANIMATION", ""));
            this.Fields.Add(new WordFlagsField("flags", "synchronized"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<LensFlareScalarAnimationBlock>("brightness", 1));
            this.Fields.Add(new BlockField<LensFlareColorAnimationBlock>("color", 1));
            this.Fields.Add(new BlockField<LensFlareScalarAnimationBlock>("rotation", 1));
        }
        /// <summary>
        /// Gets and returns the name of the lens_flare_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "lens_flare_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lens_flare_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "lens_flare";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lens_flare_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lens_flare_block tag block.
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
