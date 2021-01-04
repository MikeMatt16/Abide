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
    /// Represents the generated damage_seat_info_block tag block.
    /// </summary>
    public sealed class DamageSeatInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageSeatInfoBlock"/> class.
        /// </summary>
        public DamageSeatInfoBlock()
        {
            this.Fields.Add(new StringIdField("seat label^"));
            this.Fields.Add(new RealFractionField("direct damage scale#0==no damage, 1==full damage"));
            this.Fields.Add(new RealField("damage transfer fall-off radius"));
            this.Fields.Add(new RealField("maximum transfer damage scale"));
            this.Fields.Add(new RealField("minimum transfer damage scale"));
        }
        /// <summary>
        /// Gets and returns the name of the damage_seat_info_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "damage_seat_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the damage_seat_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "damage_seat_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the damage_seat_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the damage_seat_info_block tag block.
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
