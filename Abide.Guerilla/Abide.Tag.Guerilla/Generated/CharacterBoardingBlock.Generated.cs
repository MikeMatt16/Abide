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
    /// Represents the generated character_boarding_block tag block.
    /// </summary>
    public sealed class CharacterBoardingBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterBoardingBlock"/> class.
        /// </summary>
        public CharacterBoardingBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "airborne boarding"));
            this.Fields.Add(new RealField("max distance:wus#maximum distance from entry point that we will consider boarding" +
                        ""));
            this.Fields.Add(new RealField("abort distance:wus#give up trying to get in boarding seat if entry point is furth" +
                        "er away than this"));
            this.Fields.Add(new RealField("max speed:wu/s#maximum speed at which we will consider boarding"));
        }
        /// <summary>
        /// Gets and returns the name of the character_boarding_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_boarding_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_boarding_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_boarding_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_boarding_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_boarding_block tag block.
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
