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
    /// Represents the generated hud_screen_effect_widgets tag block.
    /// </summary>
    public sealed class HudScreenEffectWidgets : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudScreenEffectWidgets"/> class.
        /// </summary>
        public HudScreenEffectWidgets()
        {
            this.Fields.Add(new StringIdField("name"));
            this.Fields.Add(new StructField<HudWidgetInputsStructBlock>(""));
            this.Fields.Add(new StructField<HudWidgetStateDefinitionStructBlock>(""));
            this.Fields.Add(new EnumField("anchor", "health and shield", "weapon hud", "motion sensor", "scoreboard", "crosshair", "lock-on target"));
            this.Fields.Add(new WordFlagsField("flags", "unused"));
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
            this.Fields.Add(new TagReferenceField("fullscreen screen effect", 1701277554));
            this.Fields.Add(new StructField<ScreenEffectBonusStructBlock>("waa"));
            this.Fields.Add(new CharIntegerField("fullscreen sequence index"));
            this.Fields.Add(new CharIntegerField("halfscreen sequence index"));
            this.Fields.Add(new CharIntegerField("quarterscreen sequence index"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new Point2dField("fullscreen offset"));
            this.Fields.Add(new Point2dField("halfscreen offset"));
            this.Fields.Add(new Point2dField("quarterscreen offset"));
        }
        /// <summary>
        /// Gets and returns the name of the hud_screen_effect_widgets tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "hud_screen_effect_widgets";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_screen_effect_widgets tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_screen_effect_widgets";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_screen_effect_widgets tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_screen_effect_widgets tag block.
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