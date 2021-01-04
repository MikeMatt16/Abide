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
    /// Represents the generated pathfinding_object_index_list_block tag block.
    /// </summary>
    public sealed class PathfindingObjectIndexListBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathfindingObjectIndexListBlock"/> class.
        /// </summary>
        public PathfindingObjectIndexListBlock()
        {
            this.Fields.Add(new ShortIntegerField("BSP Index"));
            this.Fields.Add(new ShortIntegerField("Pathfinding Object Index"));
        }
        /// <summary>
        /// Gets and returns the name of the pathfinding_object_index_list_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "pathfinding_object_index_list_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pathfinding_object_index_list_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pathfinding_object_index_list_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pathfinding_object_index_list_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pathfinding_object_index_list_block tag block.
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
