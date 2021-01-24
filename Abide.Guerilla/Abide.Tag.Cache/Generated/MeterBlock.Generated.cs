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
    /// Represents the generated meter_block tag block.
    /// </summary>
    public sealed class MeterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeterBlock"/> class.
        /// </summary>
        public MeterBlock()
        {
            this.Fields.Add(new LongFlagsField("flags"));
            this.Fields.Add(new TagReferenceField("stencil bitmaps#two bitmaps specifying the mask and the meter levels", 1651078253));
            this.Fields.Add(new TagReferenceField("source bitmap#optional bitmap to draw into the unmasked regions of the meter (mod" +
                        "ulated by the colors below)", 1651078253));
            this.Fields.Add(new ShortIntegerField("stencil sequence index"));
            this.Fields.Add(new ShortIntegerField("source sequence index"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new EnumField("interpolate colors...", "linearly", "faster near empty", "faster near full", "through random noise"));
            this.Fields.Add(new EnumField("anchor colors...", "at both ends", "at empty", "at full"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new RealArgbColorField("empty color"));
            this.Fields.Add(new RealArgbColorField("full color"));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new RealField("unmask distance:meter units#fade from fully masked to fully unmasked this distanc" +
                        "e beyond full (and below empty)"));
            this.Fields.Add(new RealField("mask distance:meter units#fade from fully unmasked to fully masked this distance " +
                        "below full (and beyond empty)"));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new DataField("encoded stencil", 1, 4));
        }
        /// <summary>
        /// Gets and returns the name of the meter_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "meter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the meter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "meter";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the meter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the meter_block tag block.
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
