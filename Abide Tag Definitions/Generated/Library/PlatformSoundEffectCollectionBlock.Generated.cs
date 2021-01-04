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
    /// Represents the generated platform_sound_effect_collection_block tag block.
    /// </summary>
    public sealed class PlatformSoundEffectCollectionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformSoundEffectCollectionBlock"/> class.
        /// </summary>
        public PlatformSoundEffectCollectionBlock()
        {
            this.Fields.Add(new BlockField<PlatformSoundEffectBlock>("sound effects*", 8));
            this.Fields.Add(new BlockField<PlatformSoundEffectFunctionBlock>("low frequency input*", 16));
            this.Fields.Add(new LongIntegerField("sound effect overrides"));
        }
        /// <summary>
        /// Gets and returns the name of the platform_sound_effect_collection_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "platform_sound_effect_collection_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the platform_sound_effect_collection_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "platform_sound_effect_collection_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the platform_sound_effect_collection_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the platform_sound_effect_collection_block tag block.
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
