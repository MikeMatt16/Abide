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
    /// Represents the generated simple_platform_sound_playback_struct_block tag block.
    /// </summary>
    public sealed class SimplePlatformSoundPlaybackStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePlatformSoundPlaybackStructBlock"/> class.
        /// </summary>
        public SimplePlatformSoundPlaybackStructBlock()
        {
            this.Fields.Add(new BlockField<PlatformSoundOverrideMixbinsBlock>("", 8));
            this.Fields.Add(new LongFlagsField("flags", "use 3d radio hack"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new BlockField<PlatformSoundFilterBlock>("filter", 1));
            this.Fields.Add(new BlockField<PlatformSoundPitchLfoBlock>("pitch lfo", 1));
            this.Fields.Add(new BlockField<PlatformSoundFilterLfoBlock>("filter lfo", 1));
            this.Fields.Add(new BlockField<SoundEffectPlaybackBlock>("sound effect", 1));
        }
        /// <summary>
        /// Gets and returns the name of the simple_platform_sound_playback_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "simple_platform_sound_playback_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the simple_platform_sound_playback_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "simple_platform_sound_playback_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the simple_platform_sound_playback_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the simple_platform_sound_playback_struct_block tag block.
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
