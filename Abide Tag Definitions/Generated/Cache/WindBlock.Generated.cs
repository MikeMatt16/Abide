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
    /// Represents the generated wind_block tag block.
    /// </summary>
    public sealed class WindBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindBlock"/> class.
        /// </summary>
        public WindBlock()
        {
            this.Fields.Add(new RealBoundsField("velocity:world units#the wind magnitude in the weather region scales the wind bet" +
                        "ween these bounds"));
            this.Fields.Add(new EulerAngles2dField("variation area#the wind direction varies inside a box defined by these angles on " +
                        "either side of the direction from the weather region."));
            this.Fields.Add(new RealField("local variation weight"));
            this.Fields.Add(new RealField("local variation rate"));
            this.Fields.Add(new RealField("damping"));
            this.Fields.Add(new PadField("", 36));
        }
        /// <summary>
        /// Gets and returns the name of the wind_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "wind_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the wind_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "wind";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the wind_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the wind_block tag block.
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
