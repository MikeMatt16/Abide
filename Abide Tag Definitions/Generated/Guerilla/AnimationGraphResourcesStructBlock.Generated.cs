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
    /// Represents the generated animation_graph_resources_struct_block tag block.
    /// </summary>
    public sealed class AnimationGraphResourcesStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationGraphResourcesStructBlock"/> class.
        /// </summary>
        public AnimationGraphResourcesStructBlock()
        {
            this.Fields.Add(new ExplanationField("GRAPH DATA", ""));
            this.Fields.Add(new TagReferenceField("parent animation graph", 1785553252));
            this.Fields.Add(new ByteFlagsField("inheritance flags", "inherit root trans scale only", "inherit for use on player"));
            this.Fields.Add(new ByteFlagsField("private flags*", "prepared for cache", "unused", "imported with codec compressors", "unused smelly flag", "written to cache", "animation data reordered"));
            this.Fields.Add(new ShortIntegerField("animation codec pack*"));
            this.Fields.Add(new BlockField<AnimationGraphNodeBlock>("skeleton nodes*", 255));
            this.Fields.Add(new BlockField<AnimationGraphSoundReferenceBlock>("sound references|ABCDCC", 512));
            this.Fields.Add(new BlockField<AnimationGraphEffectReferenceBlock>("effect references|ABCDCC", 512));
            this.Fields.Add(new BlockField<AnimationBlendScreenBlock>("blend screens|ABCDCC", 64));
            this.Fields.Add(new BlockField<AnimationPoolBlock>("animations*", 2048));
        }
        /// <summary>
        /// Gets and returns the name of the animation_graph_resources_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "animation_graph_resources_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_graph_resources_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_graph_resources_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_graph_resources_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_graph_resources_struct_block tag block.
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
