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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(40, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("sound_effect_template", "<fx>", "����", typeof(SoundEffectTemplateBlock))]
    public class SoundEffectTemplateBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("template collection", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Sound Effect Templates Block", 8, typeof(SoundEffectTemplatesBlock))]
        public TagBlock TemplateCollection;
        [Abide.Guerilla.Tags.FieldAttribute("input effect name", typeof(StringId))]
        public StringId InputEffectName;
        [Abide.Guerilla.Tags.FieldAttribute("additional sound inputs", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Sound Effect Template Additional Sound Input Block", 1, typeof(SoundEffectTemplateAdditionalSoundInputBlock))]
        public TagBlock AdditionalSoundInputs;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Platform Sound Effect Template Collection Block", 1, typeof(PlatformSoundEffectTemplateCollectionBlock))]
        public TagBlock EmptyString;
    }
}
#pragma warning restore CS1591
