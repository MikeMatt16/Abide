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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
    public class ShaderStateMiscStateBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("fog color", typeof(ColorRgb))]
        public ColorRgb FogColor;
        public enum FlagsOptions
        {
            YuvToRgb = 1,
            _16bitDither = 2,
            _32bitDxt1Noise = 4,
        }
    }
}
#pragma warning restore CS1591
