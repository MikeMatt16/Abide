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
    /// Represents the generated damage_effect_player_response_block tag block.
    /// </summary>
    public sealed class DamageEffectPlayerResponseBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageEffectPlayerResponseBlock"/> class.
        /// </summary>
        public DamageEffectPlayerResponseBlock()
        {
            this.Fields.Add(new EnumField("response type", "shielded", "unshielded", "all"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("screen flash", @"There are seven screen flash types:

NONE: DST'= DST
LIGHTEN: DST'= DST(1 - A) + C
DARKEN: DST'= DST(1 - A) - C
MAX: DST'= MAX[DST(1 - C), (C - A)(1-DST)]
MIN: DST'= MIN[DST(1 - C), (C + A)(1-DST)]
TINT: DST'= DST(1 - C) + (A*PIN[2C - 1, 0, 1] + A)(1-DST)
INVERT: DST'= DST(1 - C) + A)

In the above equations C and A represent the color and alpha of the screen flash, DST represents the color in the framebuffer before the screen flash is applied, and DST' represents the color after the screen flash is applied."));
            this.Fields.Add(new StructField<ScreenFlashDefinitionStructBlock>("screen flash*"));
            this.Fields.Add(new ExplanationField("vibration", ""));
            this.Fields.Add(new StructField<VibrationDefinitionStructBlock>("vibration*"));
            this.Fields.Add(new ExplanationField("sound effect", ""));
            this.Fields.Add(new StructField<DamageEffectSoundEffectDefinitionBlock>("sound effect"));
        }
        /// <summary>
        /// Gets and returns the name of the damage_effect_player_response_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "damage_effect_player_response_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the damage_effect_player_response_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "damage_effect_player_response_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the damage_effect_player_response_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the damage_effect_player_response_block tag block.
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
