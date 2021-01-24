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
    /// Represents the generated character_search_block tag block.
    /// </summary>
    public sealed class CharacterSearchBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterSearchBlock"/> class.
        /// </summary>
        public CharacterSearchBlock()
        {
            this.Fields.Add(new LongFlagsField("Search flags", "crouch on investigate", "walk on pursuit"));
            this.Fields.Add(new RealBoundsField("search time"));
            this.Fields.Add(new ExplanationField("Uncover", ""));
            this.Fields.Add(new RealBoundsField("Uncover distance bounds#Distance of uncover point from target. Hard lower limit, " +
                        "soft upper limit."));
        }
        /// <summary>
        /// Gets and returns the name of the character_search_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "character_search_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_search_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_search_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_search_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_search_block tag block.
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
