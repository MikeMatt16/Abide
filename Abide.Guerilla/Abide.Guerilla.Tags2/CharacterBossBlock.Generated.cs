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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    public class CharacterBossBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("flurry damage threshold:[0..1]#when more than x damage is caused a juggernaut flu" +
            "rry is triggered", typeof(Single))]
        public Single FlurryDamageThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("flurry time:seconds#flurry lasts this long", typeof(Single))]
        public Single FlurryTime;
    }
}
#pragma warning restore CS1591