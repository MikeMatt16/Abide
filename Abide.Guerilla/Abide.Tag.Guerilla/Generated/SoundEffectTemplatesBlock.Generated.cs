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
    /// Represents the generated sound_effect_templates_block tag block.
    /// </summary>
    public sealed class SoundEffectTemplatesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectTemplatesBlock"/> class.
        /// </summary>
        public SoundEffectTemplatesBlock()
        {
            this.Fields.Add(new StringIdField("dsp effect"));
            this.Fields.Add(new ExplanationField("WARNING", "DON\'T MODIFY THIS TAG UNLESS YOU KNOW WHAT YOU ARE DOING"));
            this.Fields.Add(new DataField("explanation", 1, 4));
            this.Fields.Add(new LongFlagsField("flags", "use high level parameters", "custom parameters"));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new BlockField<SoundEffectTemplateParameterBlock>("parameters", 128));
        }
        /// <summary>
        /// Gets and returns the name of the sound_effect_templates_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_effect_templates_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_effect_templates_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_effect_templates_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_effect_templates_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_effect_templates_block tag block.
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
