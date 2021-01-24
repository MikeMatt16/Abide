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
    /// Represents the generated sound_pitch_range_block tag block.
    /// </summary>
    public sealed class SoundPitchRangeBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundPitchRangeBlock"/> class.
        /// </summary>
        public SoundPitchRangeBlock()
        {
            this.Fields.Add(new StringIdField("name*#the name of the imported pitch range directory"));
            this.Fields.Add(new ExplanationField("pitch control", "these settings control what pitches this set of samples represents. if there is o" +
                        "nly one pitch range, all three values are ignored."));
            this.Fields.Add(new ShortIntegerField("natural pitch:cents#the apparent pitch when these samples are played at their rec" +
                        "orded pitch."));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBoundsField("bend bounds:cents#the range of pitches that will be represented using this sample" +
                        "."));
            this.Fields.Add(new ShortBoundsField(""));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new BlockField<SoundPermutationsBlock>("permutations*#permutations represent equivalent variations of this sound.", 32));
        }
        /// <summary>
        /// Gets and returns the name of the sound_pitch_range_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_pitch_range_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_pitch_range_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_pitch_range_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_pitch_range_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 9;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_pitch_range_block tag block.
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
