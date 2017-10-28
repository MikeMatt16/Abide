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
    public class Magazines
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("rounds recharged:per second", typeof(Int16))]
        public Int16 RoundsRecharged;
        [Abide.Guerilla.Tags.FieldAttribute("rounds total initial", typeof(Int16))]
        public Int16 RoundsTotalInitial;
        [Abide.Guerilla.Tags.FieldAttribute("rounds total maximum", typeof(Int16))]
        public Int16 RoundsTotalMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("rounds loaded maximum", typeof(Int16))]
        public Int16 RoundsLoadedMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("reload time:seconds#the length of time it takes to load a single magazine into th" +
            "e weapon", typeof(Single))]
        public Single ReloadTime;
        [Abide.Guerilla.Tags.FieldAttribute("rounds reloaded", typeof(Int16))]
        public Int16 RoundsReloaded;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("chamber time:seconds#the length of time it takes to chamber the next round", typeof(Single))]
        public Single ChamberTime;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(8)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(16)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("reloading effect", typeof(TagReference))]
        public TagReference ReloadingEffect;
        [Abide.Guerilla.Tags.FieldAttribute("reloading damage effect", typeof(TagReference))]
        public TagReference ReloadingDamageEffect;
        [Abide.Guerilla.Tags.FieldAttribute("chambering effect", typeof(TagReference))]
        public TagReference ChamberingEffect;
        [Abide.Guerilla.Tags.FieldAttribute("chambering damage effect", typeof(TagReference))]
        public TagReference ChamberingDamageEffect;
        [Abide.Guerilla.Tags.FieldAttribute("magazines", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Magazine Objects", 8, typeof(MagazineObjects))]
        public TagBlock Magazines1;
        public enum FlagsOptions
        {
            WastesRoundsWhenReloaded = 1,
            EveryRoundMustBeChambered = 2,
        }
    }
}
#pragma warning restore CS1591
