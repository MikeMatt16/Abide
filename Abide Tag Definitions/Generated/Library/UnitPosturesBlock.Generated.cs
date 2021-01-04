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
    /// Represents the generated unit_postures_block tag block.
    /// </summary>
    public sealed class UnitPosturesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitPosturesBlock"/> class.
        /// </summary>
        public UnitPosturesBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new RealVector3dField("pill offset"));
        }
        /// <summary>
        /// Gets and returns the name of the unit_postures_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_postures_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_postures_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_postures_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_postures_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_postures_block tag block.
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
