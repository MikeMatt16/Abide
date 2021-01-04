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
    /// Represents the generated collision_model_node_block tag block.
    /// </summary>
    public sealed class CollisionModelNodeBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModelNodeBlock"/> class.
        /// </summary>
        public CollisionModelNodeBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBlockIndexField("parent node*"));
            this.Fields.Add(new ShortBlockIndexField("next sibling node*"));
            this.Fields.Add(new ShortBlockIndexField("first child node*"));
        }
        /// <summary>
        /// Gets and returns the name of the collision_model_node_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "collision_model_node_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_model_node_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "collision_model_node_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_model_node_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_model_node_block tag block.
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