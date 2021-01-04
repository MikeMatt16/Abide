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
    /// Represents the generated map_leaf_face_vertex_block tag block.
    /// </summary>
    public sealed class MapLeafFaceVertexBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapLeafFaceVertexBlock"/> class.
        /// </summary>
        public MapLeafFaceVertexBlock()
        {
            this.Fields.Add(new RealPoint3dField("vertex*"));
        }
        /// <summary>
        /// Gets and returns the name of the map_leaf_face_vertex_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "map_leaf_face_vertex_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the map_leaf_face_vertex_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "map_leaf_face_vertex_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the map_leaf_face_vertex_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the map_leaf_face_vertex_block tag block.
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
