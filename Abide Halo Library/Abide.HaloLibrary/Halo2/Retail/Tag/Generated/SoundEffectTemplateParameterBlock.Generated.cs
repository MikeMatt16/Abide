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
    /// Represents the generated sound_effect_template_parameter_block tag block.
    /// </summary>
    public sealed class SoundEffectTemplateParameterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectTemplateParameterBlock"/> class.
        /// </summary>
        public SoundEffectTemplateParameterBlock()
        {
            this.Fields.Add(new StringIdField("name"));
            this.Fields.Add(new EnumField("type", "integer", "real", "filter type"));
            this.Fields.Add(new WordFlagsField("flags", "expose as function"));
            this.Fields.Add(new LongIntegerField("hardware offset"));
            this.Fields.Add(new LongIntegerField("default enum integer value"));
            this.Fields.Add(new RealField("default scalar value"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("default function"));
            this.Fields.Add(new RealField("minimum scalar value"));
            this.Fields.Add(new RealField("maximum scalar value"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_effect_template_parameter_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_effect_template_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_effect_template_parameter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_effect_template_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_effect_template_parameter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_effect_template_parameter_block tag block.
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