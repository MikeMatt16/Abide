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
    /// Represents the generated looping_sound_detail_block tag block.
    /// </summary>
    public sealed class LoopingSoundDetailBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoopingSoundDetailBlock"/> class.
        /// </summary>
        public LoopingSoundDetailBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new TagReferenceField("sound", 1936614433));
            this.Fields.Add(new ExplanationField("frequency of play", ""));
            this.Fields.Add(new RealBoundsField("random period bounds:seconds#the time between successive playings of this sound w" +
                        "ill be randomly selected from this range."));
            this.Fields.Add(new RealField(""));
            this.Fields.Add(new LongFlagsField("flags", "don\'t play with alternate", "don\'t play without alternate", "start immediately with loop"));
            this.Fields.Add(new ExplanationField("random spatialization", @"if the sound specified above is not stereo it will be randomly spatialized according to the following constraints. if both lower and upper bounds are zero for any of the following fields, the sound's position will be randomly selected from all possible directions or distances."));
            this.Fields.Add(new AngleBoundsField("yaw bounds:degrees#the sound\'s position along the horizon will be randomly select" +
                        "ed from this range."));
            this.Fields.Add(new AngleBoundsField("pitch bounds:degrees#the sound\'s position above (positive values) or below (negat" +
                        "ive values) the horizon will be randomly selected from this range."));
            this.Fields.Add(new RealBoundsField("distance bounds:world units#the sound\'s distance (from its spatialized looping so" +
                        "und or from the listener if the looping sound is stereo) will be randomly select" +
                        "ed from this range."));
        }
        /// <summary>
        /// Gets and returns the name of the looping_sound_detail_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "looping_sound_detail_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the looping_sound_detail_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "looping_sound_detail_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the looping_sound_detail_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 12;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the looping_sound_detail_block tag block.
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
