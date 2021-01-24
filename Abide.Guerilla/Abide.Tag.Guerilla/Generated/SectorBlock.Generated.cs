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
    /// Represents the generated sector_block tag block.
    /// </summary>
    public sealed class SectorBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectorBlock"/> class.
        /// </summary>
        public SectorBlock()
        {
            this.Fields.Add(new WordFlagsField("Path-finding sector flags", "sector walkable", "sector breakable", "sector mobile", "sector bsp source", "floor", "ceiling", "wall north", "wall south", "wall east", "wall west", "crouchable", "aligned", "sector step", "sector interior"));
            this.Fields.Add(new ShortIntegerField("hint index"));
            this.Fields.Add(new LongIntegerField("first link (do not set manually)"));
        }
        /// <summary>
        /// Gets and returns the name of the sector_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sector_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sector_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sector_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sector_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65534;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sector_block tag block.
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
