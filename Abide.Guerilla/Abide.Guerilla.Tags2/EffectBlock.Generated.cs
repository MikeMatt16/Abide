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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(64, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("effect", "effe", "����", typeof(EffectBlock))]
    public class EffectBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("loop start event", typeof(Int16))]
        public Int16 LoopStartEvent;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("locations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Effect Locations Block", 32, typeof(EffectLocationsBlock))]
        public TagBlock Locations;
        [Abide.Guerilla.Tags.FieldAttribute("events", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Effect Event Block", 32, typeof(EffectEventBlock))]
        public TagBlock Events;
        [Abide.Guerilla.Tags.FieldAttribute("looping sound", typeof(TagReference))]
        public TagReference LoopingSound1;
        [Abide.Guerilla.Tags.FieldAttribute("location", typeof(Int16))]
        public Int16 Location;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("always play distance", typeof(Single))]
        public Single AlwaysPlayDistance;
        [Abide.Guerilla.Tags.FieldAttribute("never play distance", typeof(Single))]
        public Single NeverPlayDistance;
        public enum FlagsOptions
        {
            DeletedWhenAttachmentDeactivates = 1,
        }
    }
}
#pragma warning restore CS1591
