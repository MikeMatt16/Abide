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
    /// Represents the generated player_representation_block tag block.
    /// </summary>
    public sealed class PlayerRepresentationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRepresentationBlock"/> class.
        /// </summary>
        public PlayerRepresentationBlock()
        {
            this.Fields.Add(new TagReferenceField("first person hands", 1836016741));
            this.Fields.Add(new TagReferenceField("first person body", 1836016741));
            this.Fields.Add(new PadField("", 40));
            this.Fields.Add(new PadField("", 120));
            this.Fields.Add(new TagReferenceField("third person unit", 1970170228));
            this.Fields.Add(new StringIdField("third person variant"));
        }
        /// <summary>
        /// Gets and returns the name of the player_representation_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "player_representation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the player_representation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "player_representation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the player_representation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the player_representation_block tag block.
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
