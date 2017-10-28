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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(244, 4)]
    public class GameEngineSlayerEventBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("event^", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Event), false)]
        public Int16 Event1;
        [Abide.Guerilla.Tags.FieldAttribute("audience^", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Audience), false)]
        public Int16 Audience1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("display string", typeof(StringId))]
        public StringId DisplayString;
        [Abide.Guerilla.Tags.FieldAttribute("required field", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(RequiredFieldOptions), false)]
        public Int16 RequiredField;
        [Abide.Guerilla.Tags.FieldAttribute("excluded audience", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ExcludedAudienceOptions), false)]
        public Int16 ExcludedAudience;
        [Abide.Guerilla.Tags.FieldAttribute("primary string", typeof(StringId))]
        public StringId PrimaryString;
        [Abide.Guerilla.Tags.FieldAttribute("primary string duration:seconds", typeof(Int32))]
        public Int32 PrimaryStringDuration;
        [Abide.Guerilla.Tags.FieldAttribute("plural display string", typeof(StringId))]
        public StringId PluralDisplayString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(28)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("sound delay (announcer only)", typeof(Single))]
        public Single SoundDelayAnnouncerOnly;
        [Abide.Guerilla.Tags.FieldAttribute("sound flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(SoundFlagsOptions), true)]
        public Int16 SoundFlags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("sound^", typeof(TagReference))]
        public TagReference Sound;
        [Abide.Guerilla.Tags.FieldAttribute("extra sounds", typeof(SoundResponseExtraSoundsStructBlock))]
        public SoundResponseExtraSoundsStructBlock ExtraSounds;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(16)]
        public Byte[] EmptyString6;
        [Abide.Guerilla.Tags.FieldAttribute("sound permutations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Sound Response Definition Block", 10, typeof(SoundResponseDefinitionBlock))]
        public TagBlock SoundPermutations;
        public enum FlagsOptions
        {
            QuantityMessage = 1,
        }
        public enum Event
        {
            GameStart = 0,
            NewTarget = 1,
        }
        public enum Audience
        {
            CausePlayer = 0,
            CauseTeam = 1,
            EffectPlayer = 2,
            EffectTeam = 3,
            All = 4,
        }
        public enum RequiredFieldOptions
        {
            None = 0,
            CausePlayer = 1,
            CauseTeam = 2,
            EffectPlayer = 3,
            EffectTeam = 4,
        }
        public enum ExcludedAudienceOptions
        {
            None = 0,
            CausePlayer = 1,
            CauseTeam = 2,
            EffectPlayer = 3,
            EffectTeam = 4,
        }
        public enum SoundFlagsOptions
        {
            AnnouncerSound = 1,
        }
    }
}
#pragma warning restore CS1591
