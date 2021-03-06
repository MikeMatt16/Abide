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
    /// Represents the generated unit_seat_acceleration_struct_block tag block.
    /// </summary>
    public sealed class UnitSeatAccelerationStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitSeatAccelerationStructBlock"/> class.
        /// </summary>
        public UnitSeatAccelerationStructBlock()
        {
            this.Fields.Add(new RealVector3dField("acceleration range:world units per second squared"));
            this.Fields.Add(new RealField("accel action scale:actions fail [0,1+]"));
            this.Fields.Add(new RealField("accel attach scale:detach unit [0,1+]"));
        }
        /// <summary>
        /// Gets and returns the name of the unit_seat_acceleration_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_seat_acceleration_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_seat_acceleration_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_seat_acceleration_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_seat_acceleration_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_seat_acceleration_struct_block tag block.
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
