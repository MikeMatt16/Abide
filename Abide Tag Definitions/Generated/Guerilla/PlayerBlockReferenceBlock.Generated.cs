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
    /// Represents the generated player_block_reference_block tag block.
    /// </summary>
    public sealed class PlayerBlockReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerBlockReferenceBlock"/> class.
        /// </summary>
        public PlayerBlockReferenceBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new TagReferenceField("skin", 1936419182));
            this.Fields.Add(new Point2dField("bottom-left"));
            this.Fields.Add(new CharEnumField("table order", "row major", "column major"));
            this.Fields.Add(new CharIntegerField("maximum player count"));
            this.Fields.Add(new CharIntegerField("row count"));
            this.Fields.Add(new CharIntegerField("column count"));
            this.Fields.Add(new ShortIntegerField("row height"));
            this.Fields.Add(new ShortIntegerField("column width"));
        }
        /// <summary>
        /// Gets and returns the name of the player_block_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "player_block_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the player_block_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "player_block_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the player_block_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the player_block_reference_block tag block.
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