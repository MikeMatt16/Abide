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
    /// Represents the generated inherited_animation_node_map_block tag block.
    /// </summary>
    public sealed class InheritedAnimationNodeMapBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InheritedAnimationNodeMapBlock"/> class.
        /// </summary>
        public InheritedAnimationNodeMapBlock()
        {
            this.Fields.Add(new ShortIntegerField("local node"));
        }
        /// <summary>
        /// Gets and returns the name of the inherited_animation_node_map_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "inherited_animation_node_map_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the inherited_animation_node_map_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "inherited_animation_node_map_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the inherited_animation_node_map_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the inherited_animation_node_map_block tag block.
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
