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
    /// Represents the generated persistent_background_animation_block tag block.
    /// </summary>
    public sealed class PersistentBackgroundAnimationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersistentBackgroundAnimationBlock"/> class.
        /// </summary>
        public PersistentBackgroundAnimationBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new LongIntegerField("animation period:milliseconds"));
            this.Fields.Add(new BlockField<BackgroundAnimationKeyframeReferenceBlock>("interpolated keyframes", 64));
        }
        /// <summary>
        /// Gets and returns the name of the persistent_background_animation_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "persistent_background_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the persistent_background_animation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "persistent_background_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the persistent_background_animation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the persistent_background_animation_block tag block.
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
