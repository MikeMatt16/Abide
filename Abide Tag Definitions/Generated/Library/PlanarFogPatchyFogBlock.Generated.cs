//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated planar_fog_patchy_fog_block tag block.
    /// </summary>
    public sealed class PlanarFogPatchyFogBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarFogPatchyFogBlock"/> class.
        /// </summary>
        public PlanarFogPatchyFogBlock()
        {
            this.Fields.Add(new RealRgbColorField("color"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealFractionBoundsField("density:[0,1]"));
            this.Fields.Add(new RealBoundsField("distance:world units"));
            this.Fields.Add(new RealFractionField("min depth fraction:[0,1]#in range (0,max_depth) world units, where patchy fog sta" +
                        "rts fading in"));
            this.Fields.Add(new TagReferenceField("patchy fog", 1718641512));
        }
        /// <summary>
        /// Gets and returns the name of the planar_fog_patchy_fog_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "planar_fog_patchy_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the planar_fog_patchy_fog_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "planar_fog_patchy_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the planar_fog_patchy_fog_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the planar_fog_patchy_fog_block tag block.
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
