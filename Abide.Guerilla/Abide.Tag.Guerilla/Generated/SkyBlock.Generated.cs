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
    /// Represents the generated sky_block tag block.
    /// </summary>
    public sealed class SkyBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkyBlock"/> class.
        /// </summary>
        public SkyBlock()
        {
            this.Fields.Add(new TagReferenceField("Render Model", 1836016741));
            this.Fields.Add(new TagReferenceField("Animation Graph", 1785553252));
            this.Fields.Add(new LongFlagsField("Flags", "Fixed in World Space", "Depreciated", "Sky Casts Light from Below", "Disable Sky in Lightmaps", "Fog Only Affects Containing Clusters", "Use Clear Color"));
            this.Fields.Add(new RealField("Render Model Scale#Multiplier by which to scale the model\'s geometry up or down (" +
                        "0 defaults to standard, 0.03)."));
            this.Fields.Add(new RealField("Movement Scale#How much the sky moves to remain centered on the player (0 default" +
                        "s to 1.0, which means no parallax)."));
            this.Fields.Add(new BlockField<SkyCubemapBlock>("Cube Map", 1));
            this.Fields.Add(new ExplanationField("AMBIENT LIGHT", ""));
            this.Fields.Add(new RealRgbColorField("Indoor Ambient Color#Indoor ambient light color."));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealRgbColorField("Outdoor Ambient Color#Indoor ambient light color."));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ExplanationField("FOG", ""));
            this.Fields.Add(new RealField("Fog Spread Distance:world units#How far fog spreads into adjacent clusters."));
            this.Fields.Add(new BlockField<SkyAtmosphericFogBlock>("Atmospheric Fog", 1));
            this.Fields.Add(new BlockField<SkyAtmosphericFogBlock>("Secondary Fog", 1));
            this.Fields.Add(new BlockField<SkyFogBlock>("Sky Fog", 1));
            this.Fields.Add(new BlockField<SkyPatchyFogBlock>("Patchy Fog", 1));
            this.Fields.Add(new ExplanationField("BLOOM OVERRIDE", ""));
            this.Fields.Add(new RealFractionField("Amount:[0,1]"));
            this.Fields.Add(new RealFractionField("Threshold:[0,1]"));
            this.Fields.Add(new RealFractionField("Brightness:[0,1]"));
            this.Fields.Add(new RealField("Gamma Power"));
            this.Fields.Add(new BlockField<SkyLightBlock>("Lights", 8));
            this.Fields.Add(new ExplanationField("ROTATION", ""));
            this.Fields.Add(new AngleField("Global Sky Rotation"));
            this.Fields.Add(new BlockField<SkyShaderFunctionBlock>("Shader Functions", 8));
            this.Fields.Add(new BlockField<SkyAnimationBlock>("Animations", 8));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealRgbColorField("Clear Color"));
        }
        /// <summary>
        /// Gets and returns the name of the sky_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sky_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sky_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sky";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sky_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sky_block tag block.
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
