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
    /// Represents the generated structure_bsp_detail_object_data_block tag block.
    /// </summary>
    public sealed class StructureBspDetailObjectDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspDetailObjectDataBlock"/> class.
        /// </summary>
        public StructureBspDetailObjectDataBlock()
        {
            this.Fields.Add(new BlockField<GlobalDetailObjectCellsBlock>("Cells", 262144));
            this.Fields.Add(new BlockField<GlobalDetailObjectBlock>("Instances", 2097152));
            this.Fields.Add(new BlockField<GlobalDetailObjectCountsBlock>("Counts", 8388608));
            this.Fields.Add(new BlockField<GlobalZReferenceVectorBlock>("z Reference Vectors", 262144));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new PadField("", 3));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_detail_object_data_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_detail_object_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_detail_object_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_detail_object_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_detail_object_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_detail_object_data_block tag block.
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
