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
    public class ZoneSetBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("area type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(AreaTypeOptions), false)]
        public Int16 AreaType;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("zone^", typeof(Int16))]
        public Int16 Zone;
        [Abide.Guerilla.Tags.FieldAttribute("area^", typeof(Int16))]
        public Int16 Area;
        public enum AreaTypeOptions
        {
            Deault = 0,
            Search = 1,
            Goal = 2,
        }
    }
}
#pragma warning restore CS1591