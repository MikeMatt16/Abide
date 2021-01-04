//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated character_palette_block tag block.
    /// </summary>
    public sealed class CharacterPaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPaletteBlock"/> class.
        /// </summary>
        public CharacterPaletteBlock()
        {
            this.Fields.Add(new TagReferenceField("reference^", 1667785074));
        }
        /// <summary>
        /// Gets and returns the name of the character_palette_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_palette_block tag block.
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
