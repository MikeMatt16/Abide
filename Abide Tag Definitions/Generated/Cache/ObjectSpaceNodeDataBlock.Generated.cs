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
    /// Represents the generated object_space_node_data_block tag block.
    /// </summary>
    public sealed class ObjectSpaceNodeDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectSpaceNodeDataBlock"/> class.
        /// </summary>
        public ObjectSpaceNodeDataBlock()
        {
            this.Fields.Add(new ShortIntegerField("node_index*"));
            this.Fields.Add(new WordFlagsField("component flags", "rotation", "translation", "scale"));
            this.Fields.Add(new StructField<QuantizedOrientationStructBlock>("orientation*"));
        }
        /// <summary>
        /// Gets and returns the name of the object_space_node_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "object_space_node_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_space_node_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_space_node_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_space_node_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_space_node_data_block tag block.
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
