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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(16, 4)]
    public class SoundPromotionRuleBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("pitch range^", typeof(Int16))]
        public Int16 PitchRange;
        [Abide.Guerilla.Tags.FieldAttribute("maximum playing count", typeof(Int16))]
        public Int16 MaximumPlayingCount;
        [Abide.Guerilla.Tags.FieldAttribute("suppression time:seconds#time from when first permutation plays to when another s" +
            "ound from an equal or lower promotion can play", typeof(Single))]
        public Single SuppressionTime;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(8)]
        public Byte[] EmptyString;
    }
}
#pragma warning restore CS1591