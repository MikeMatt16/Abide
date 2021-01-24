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
    /// Represents the generated sound_effect_template_block tag block.
    /// </summary>
    public sealed class SoundEffectTemplateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectTemplateBlock"/> class.
        /// </summary>
        public SoundEffectTemplateBlock()
        {
            this.Fields.Add(new BlockField<SoundEffectTemplatesBlock>("template collection", 8));
            this.Fields.Add(new StringIdField("input effect name"));
            this.Fields.Add(new BlockField<SoundEffectTemplateAdditionalSoundInputBlock>("additional sound inputs", 1));
            this.Fields.Add(new BlockField<PlatformSoundEffectTemplateCollectionBlock>("", 1));
        }
        /// <summary>
        /// Gets and returns the name of the sound_effect_template_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_effect_template_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_effect_template_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_effect_template";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_effect_template_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_effect_template_block tag block.
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
