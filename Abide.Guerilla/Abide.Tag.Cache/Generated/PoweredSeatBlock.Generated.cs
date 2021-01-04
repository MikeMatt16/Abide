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
    /// Represents the generated powered_seat_block tag block.
    /// </summary>
    public sealed class PoweredSeatBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoweredSeatBlock"/> class.
        /// </summary>
        public PoweredSeatBlock()
        {
            this.Fields.Add(new RealField("driver powerup time:seconds"));
            this.Fields.Add(new RealField("driver powerdown time:seconds"));
        }
        /// <summary>
        /// Gets and returns the name of the powered_seat_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "powered_seat_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the powered_seat_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "powered_seat_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the powered_seat_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the powered_seat_block tag block.
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
