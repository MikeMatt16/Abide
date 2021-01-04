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
    /// Represents the generated global_geometry_block_resource_block tag block.
    /// </summary>
    public sealed class GlobalGeometryBlockResourceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometryBlockResourceBlock"/> class.
        /// </summary>
        public GlobalGeometryBlockResourceBlock()
        {
            this.Fields.Add(new CharEnumField("Type*", "Tag Block", "Tag Data", "Vertex Buffer"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new ShortIntegerField("Primary Locator*"));
            this.Fields.Add(new ShortIntegerField("Secondary Locator*"));
            this.Fields.Add(new LongIntegerField("Resource Data Size*"));
            this.Fields.Add(new LongIntegerField("Resource Data Offset*"));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_block_resource_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_geometry_block_resource_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_block_resource_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "block resources";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_block_resource_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_block_resource_block tag block.
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
