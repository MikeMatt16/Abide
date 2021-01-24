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
    /// Represents the generated bitmap_group_sprite_block tag block.
    /// </summary>
    public sealed class BitmapGroupSpriteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitmapGroupSpriteBlock"/> class.
        /// </summary>
        public BitmapGroupSpriteBlock()
        {
            this.Fields.Add(new ShortIntegerField("Bitmap Index*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("Left*"));
            this.Fields.Add(new RealField("Right*"));
            this.Fields.Add(new RealField("Top*"));
            this.Fields.Add(new RealField("Bottom*"));
            this.Fields.Add(new RealPoint2dField("Registration Point*"));
        }
        /// <summary>
        /// Gets and returns the name of the bitmap_group_sprite_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "bitmap_group_sprite_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bitmap_group_sprite_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bitmap_group_sprite_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bitmap_group_sprite_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bitmap_group_sprite_block tag block.
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
