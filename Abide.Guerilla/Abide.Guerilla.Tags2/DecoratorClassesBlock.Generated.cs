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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
    public class DecoratorClassesBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), false)]
        public Byte Type;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(3)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("scale", typeof(Single))]
        public Single Scale;
        [Abide.Guerilla.Tags.FieldAttribute("permutations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Decorator Permutations Block", 64, typeof(DecoratorPermutationsBlock))]
        public TagBlock Permutations;
        public enum TypeOptions
        {
            Model = 0,
            FloatingDecal = 1,
            ProjectedDecal = 2,
            ScreenFacingQuad = 3,
            AxisRotatingQuad = 4,
            CrossQuad = 5,
        }
    }
}
#pragma warning restore CS1591
