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
    /// Represents the generated object_animation_block tag block.
    /// </summary>
    public sealed class ObjectAnimationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectAnimationBlock"/> class.
        /// </summary>
        public ObjectAnimationBlock()
        {
            this.Fields.Add(new StringIdField("label^"));
            this.Fields.Add(new StructField<AnimationIndexStructBlock>("animation*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("function controls", "frame", "scale"));
            this.Fields.Add(new StringIdField("function"));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the object_animation_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "object_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_animation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_animation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_animation_block tag block.
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
