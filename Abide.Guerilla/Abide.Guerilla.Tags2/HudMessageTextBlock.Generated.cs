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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(128, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("hud_message_text", "hmt ", "����", typeof(HudMessageTextBlock))]
    public class HudMessageTextBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("text data*", typeof(Byte[]))]
        public Byte[] TextData;
        [Abide.Guerilla.Tags.FieldAttribute("message elements*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Hud Message Elements Block", 8192, typeof(HudMessageElementsBlock))]
        public TagBlock MessageElements;
        [Abide.Guerilla.Tags.FieldAttribute("messages*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Hud Messages Block", 1024, typeof(HudMessagesBlock))]
        public TagBlock Messages;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(84)]
        public Byte[] EmptyString;
    }
}
#pragma warning restore CS1591