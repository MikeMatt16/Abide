#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(112, 4)]
    public class HudScreenEffectWidgets
    {
        [Abide.Guerilla.Tags.FieldAttribute("name", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(HudWidgetInputsStructBlock))]
        public HudWidgetInputsStructBlock EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(HudWidgetStateDefinitionStructBlock))]
        public HudWidgetStateDefinitionStructBlock EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("anchor", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(AnchorOptions), false)]
        public Int16 Anchor;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("bitmap", typeof(TagReference))]
        public TagReference Bitmap;
        [Abide.Guerilla.Tags.FieldAttribute("fullscreen screen effect", typeof(TagReference))]
        public TagReference FullscreenScreenEffect;
        [Abide.Guerilla.Tags.FieldAttribute("waa", typeof(ScreenEffectBonusStructBlock))]
        public ScreenEffectBonusStructBlock Waa;
        [Abide.Guerilla.Tags.FieldAttribute("fullscreen sequence index", typeof(Byte))]
        public Byte FullscreenSequenceIndex;
        [Abide.Guerilla.Tags.FieldAttribute("halfscreen sequence index", typeof(Byte))]
        public Byte HalfscreenSequenceIndex;
        [Abide.Guerilla.Tags.FieldAttribute("quarterscreen sequence index", typeof(Byte))]
        public Byte QuarterscreenSequenceIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(1)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("fullscreen offset", typeof(Vector2))]
        public Vector2 FullscreenOffset;
        [Abide.Guerilla.Tags.FieldAttribute("halfscreen offset", typeof(Vector2))]
        public Vector2 HalfscreenOffset;
        [Abide.Guerilla.Tags.FieldAttribute("quarterscreen offset", typeof(Vector2))]
        public Vector2 QuarterscreenOffset;
        public enum AnchorOptions
        {
            HealthAndShield = 0,
            WeaponHud = 1,
            MotionSensor = 2,
            Scoreboard = 3,
            Crosshair = 4,
            LockonTarget = 5,
        }
        public enum FlagsOptions
        {
            Unused = 1,
        }
    }
}
#pragma warning restore CS1591
