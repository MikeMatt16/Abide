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
    /// Represents the generated sound_gestalt_pitch_ranges_block tag block.
    /// </summary>
    public sealed class SoundGestaltPitchRangesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundGestaltPitchRangesBlock"/> class.
        /// </summary>
        public SoundGestaltPitchRangesBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("name^"));
            this.Fields.Add(new ShortBlockIndexField("parameters"));
            this.Fields.Add(new ShortIntegerField("encoded permutation data"));
            this.Fields.Add(new ShortIntegerField("first runtime permutation flag index"));
            this.Fields.Add(new ShortBlockIndexField("first permutation"));
            this.Fields.Add(new ShortIntegerField("permutation count"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_gestalt_pitch_ranges_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_gestalt_pitch_ranges_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_gestalt_pitch_ranges_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_gestalt_pitch_ranges_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_gestalt_pitch_ranges_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32767;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_gestalt_pitch_ranges_block tag block.
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
