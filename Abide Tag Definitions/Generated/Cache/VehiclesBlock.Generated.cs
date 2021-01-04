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
    /// Represents the generated vehicles_block tag block.
    /// </summary>
    public sealed class VehiclesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclesBlock"/> class.
        /// </summary>
        public VehiclesBlock()
        {
            this.Fields.Add(new TagReferenceField("vehicle^", 1986357353));
        }
        /// <summary>
        /// Gets and returns the name of the vehicles_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "vehicles_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the vehicles_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vehicles_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the vehicles_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the vehicles_block tag block.
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
