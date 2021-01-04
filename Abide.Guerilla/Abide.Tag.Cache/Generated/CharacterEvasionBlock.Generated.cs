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
    /// Represents the generated character_evasion_block tag block.
    /// </summary>
    public sealed class CharacterEvasionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEvasionBlock"/> class.
        /// </summary>
        public CharacterEvasionBlock()
        {
            this.Fields.Add(new RealField("Evasion danger threshold#Consider evading when immediate danger surpasses thresho" +
                        "ld"));
            this.Fields.Add(new RealField("Evasion delay timer#Wait at least this delay between evasions"));
            this.Fields.Add(new RealField("Evasion chance#If danger is above threshold, the chance that we will evade. Expre" +
                        "ssed as chance of evading within a 1 second time period"));
            this.Fields.Add(new RealField("Evasion proximity threshold#If target is within given proximity, possibly evade"));
            this.Fields.Add(new RealField("dive retreat chance#Chance of retreating (fleeing) after danger avoidance dive"));
        }
        /// <summary>
        /// Gets and returns the name of the character_evasion_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_evasion_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_evasion_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_evasion_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_evasion_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_evasion_block tag block.
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