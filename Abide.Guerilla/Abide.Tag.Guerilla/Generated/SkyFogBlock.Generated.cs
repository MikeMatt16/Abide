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
    /// Represents the generated sky_fog_block tag block.
    /// </summary>
    public sealed class SkyFogBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkyFogBlock"/> class.
        /// </summary>
        public SkyFogBlock()
        {
            this.Fields.Add(new RealRgbColorField("Color"));
            this.Fields.Add(new RealFractionField("Density:[0,1]#Fog density is clamped to this value."));
        }
        /// <summary>
        /// Gets and returns the name of the sky_fog_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sky_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sky_fog_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sky_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sky_fog_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sky_fog_block tag block.
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
