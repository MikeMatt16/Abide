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
    public class ModelVariantRegionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("region name^:must match region name in render_model", typeof(StringId))]
        public StringId RegionName;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(1)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(1)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("parent variant", typeof(Int16))]
        public Int16 ParentVariant;
        [Abide.Guerilla.Tags.FieldAttribute("permutations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Permutation", 32, typeof(ModelVariantPermutationBlock))]
        public TagBlock Permutations;
        [Abide.Guerilla.Tags.FieldAttribute("sort order#negative values mean closer to the camera", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(SortOrder), false)]
        public Int16 SortOrder1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString2;
        public enum SortOrder
        {
            NoSorting = 0,
            _5Closest = 1,
            _4 = 2,
            _3 = 3,
            _2 = 4,
            _1 = 5,
            _0SameAsModel = 6,
            _11 = 7,
            _21 = 8,
            _31 = 9,
            _41 = 10,
            _5Farthest = 11,
        }
    }
}
#pragma warning restore CS1591
