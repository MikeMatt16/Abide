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
    /// Represents the generated animation_graph_effect_reference_block tag block.
    /// </summary>
    public sealed class AnimationGraphEffectReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationGraphEffectReferenceBlock"/> class.
        /// </summary>
        public AnimationGraphEffectReferenceBlock()
        {
            this.Fields.Add(new TagReferenceField("effect^", 1701209701));
            this.Fields.Add(new WordFlagsField("flags", "allow on player", "left arm only", "right arm only", "first-person only", "forward only", "reverse only"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the animation_graph_effect_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "animation_graph_effect_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_graph_effect_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_graph_effect_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_graph_effect_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_graph_effect_reference_block tag block.
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
