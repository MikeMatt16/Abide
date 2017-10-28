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
    public class SkyRadiosityLightBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("Color:#Light color.", typeof(ColorRgbF))]
        public ColorRgbF Color;
        [Abide.Guerilla.Tags.FieldAttribute("Power:[0,+inf]#Light power from 0 to infinity.", typeof(Single))]
        public Single Power;
        [Abide.Guerilla.Tags.FieldAttribute("Test Distance:world units#Length of the ray for shadow testing.", typeof(Single))]
        public Single TestDistance;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("Diameter:degrees#Angular diameter of the light source in the sky.", typeof(Single))]
        public Single Diameter;
        public enum FlagsOptions
        {
            AffectsExteriors = 1,
            AffectsInteriors = 2,
            DirectIlluminationInLightmaps = 4,
            IndirectIlluminationInLightmaps = 8,
        }
    }
}
#pragma warning restore CS1591
