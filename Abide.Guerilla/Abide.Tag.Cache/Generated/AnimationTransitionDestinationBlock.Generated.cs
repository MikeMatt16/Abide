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
    /// Represents the generated animation_transition_destination_block tag block.
    /// </summary>
    public sealed class AnimationTransitionDestinationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationTransitionDestinationBlock"/> class.
        /// </summary>
        public AnimationTransitionDestinationBlock()
        {
            this.Fields.Add(new StringIdField("full name^#name of the mode & state this transitions to"));
            this.Fields.Add(new StringIdField("mode*#name of the mode"));
            this.Fields.Add(new StructField<AnimationDestinationStateStructBlock>("state info"));
            this.Fields.Add(new StructField<AnimationIndexStructBlock>("animation*"));
        }
        /// <summary>
        /// Gets and returns the name of the animation_transition_destination_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "animation_transition_destination_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_transition_destination_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_transition_destination_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_transition_destination_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_transition_destination_block tag block.
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
