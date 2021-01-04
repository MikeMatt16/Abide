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
    /// Represents the generated sky_atmospheric_fog_block tag block.
    /// </summary>
    public sealed class SkyAtmosphericFogBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkyAtmosphericFogBlock"/> class.
        /// </summary>
        public SkyAtmosphericFogBlock()
        {
            this.Fields.Add(new RealRgbColorField("Color"));
            this.Fields.Add(new RealFractionField("Maximum Density:[0,1]#Fog density is clamped to this value."));
            this.Fields.Add(new RealField("Start Distance:world units#Before this distance there is no fog."));
            this.Fields.Add(new RealField("Opaque Distance:world units#Fog becomes opaque (maximum density) at this distance" +
                        " from the viewer."));
        }
        /// <summary>
        /// Gets and returns the name of the sky_atmospheric_fog_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sky_atmospheric_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sky_atmospheric_fog_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sky_atmospheric_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sky_atmospheric_fog_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sky_atmospheric_fog_block tag block.
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
