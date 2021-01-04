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
    /// Represents the generated looping_sound_track_block tag block.
    /// </summary>
    public sealed class LoopingSoundTrackBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoopingSoundTrackBlock"/> class.
        /// </summary>
        public LoopingSoundTrackBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new LongFlagsField("flags", "fade in at start#the loop sound should fade in while the start sound is playing.", "fade out at stop#the loop sound should fade out while the stop sound is playing.", "crossfade alt loop#when the sound changes to the alternate version,  .", "master surround sound track", "fade out at alt stop"));
            this.Fields.Add(new RealField("gain:dB"));
            this.Fields.Add(new RealField("fade in duration:seconds"));
            this.Fields.Add(new RealField("fade out duration:seconds"));
            this.Fields.Add(new TagReferenceField("in", 1936614433));
            this.Fields.Add(new TagReferenceField("loop", 1936614433));
            this.Fields.Add(new TagReferenceField("out", 1936614433));
            this.Fields.Add(new TagReferenceField("alt loop", 1936614433));
            this.Fields.Add(new TagReferenceField("alt out", 1936614433));
            this.Fields.Add(new EnumField("output effect", "none", "output front speakers", "output rear speakers", "output center speakers"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("alt trans in", 1936614433));
            this.Fields.Add(new TagReferenceField("alt trans out", 1936614433));
            this.Fields.Add(new RealField("alt crossfade duration:seconds"));
            this.Fields.Add(new RealField("alt fade out duration:seconds"));
        }
        /// <summary>
        /// Gets and returns the name of the looping_sound_track_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "looping_sound_track_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the looping_sound_track_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "looping_sound_track_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the looping_sound_track_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the looping_sound_track_block tag block.
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