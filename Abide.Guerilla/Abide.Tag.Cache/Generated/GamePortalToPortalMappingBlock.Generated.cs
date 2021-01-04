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
    /// Represents the generated game_portal_to_portal_mapping_block tag block.
    /// </summary>
    public sealed class GamePortalToPortalMappingBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePortalToPortalMappingBlock"/> class.
        /// </summary>
        public GamePortalToPortalMappingBlock()
        {
            this.Fields.Add(new ShortIntegerField("portal index"));
        }
        /// <summary>
        /// Gets and returns the name of the game_portal_to_portal_mapping_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "game_portal_to_portal_mapping_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the game_portal_to_portal_mapping_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "game_portal_to_portal_mapping_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the game_portal_to_portal_mapping_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the game_portal_to_portal_mapping_block tag block.
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
