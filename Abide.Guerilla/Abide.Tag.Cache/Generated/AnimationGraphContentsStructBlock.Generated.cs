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
    /// Represents the generated animation_graph_contents_struct_block tag block.
    /// </summary>
    public sealed class AnimationGraphContentsStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationGraphContentsStructBlock"/> class.
        /// </summary>
        public AnimationGraphContentsStructBlock()
        {
            this.Fields.Add(new ExplanationField("MODE-n-STATE GRAPH", ""));
            this.Fields.Add(new BlockField<AnimationModeBlock>("modes|AABBCC", 512));
            this.Fields.Add(new ExplanationField("SPECIAL CASE ANIMS", ""));
            this.Fields.Add(new BlockField<VehicleSuspensionBlock>("vehicle suspension|CCAABB", 32));
            this.Fields.Add(new BlockField<ObjectAnimationBlock>("object overlays|CCAABB", 32));
        }
        /// <summary>
        /// Gets and returns the name of the animation_graph_contents_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "animation_graph_contents_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_graph_contents_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_graph_contents_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_graph_contents_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_graph_contents_struct_block tag block.
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