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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(152, 4)]
    public class SoundResponseDefinitionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("sound flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(SoundFlagsOptions), true)]
        public Int16 SoundFlags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("english sound^", typeof(TagReference))]
        public TagReference EnglishSound;
        [Abide.Guerilla.Tags.FieldAttribute("extra sounds", typeof(SoundResponseExtraSoundsStructBlock))]
        public SoundResponseExtraSoundsStructBlock ExtraSounds;
        [Abide.Guerilla.Tags.FieldAttribute("probability", typeof(Single))]
        public Single Probability;
        public enum SoundFlagsOptions
        {
            AnnouncerSound = 1,
        }
    }
}
#pragma warning restore CS1591
