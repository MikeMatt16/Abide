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
    /// Represents the generated character_firing_pattern_properties_block tag block.
    /// </summary>
    public sealed class CharacterFiringPatternPropertiesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterFiringPatternPropertiesBlock"/> class.
        /// </summary>
        public CharacterFiringPatternPropertiesBlock()
        {
            this.Fields.Add(new TagReferenceField("weapon^", 2003132784));
            this.Fields.Add(new BlockField<CharacterFiringPatternBlock>("firing patterns", 2));
        }
        /// <summary>
        /// Gets and returns the name of the character_firing_pattern_properties_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "character_firing_pattern_properties_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_firing_pattern_properties_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_firing_pattern_properties_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_firing_pattern_properties_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_firing_pattern_properties_block tag block.
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
