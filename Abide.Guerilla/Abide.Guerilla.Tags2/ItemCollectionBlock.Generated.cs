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
    [Abide.Guerilla.Tags.TagGroupAttribute("item_collection", "itmc", "����", typeof(ItemCollectionBlock))]
    public class ItemCollectionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("item permutations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Item Permutation", 32, typeof(ItemPermutation))]
        public TagBlock ItemPermutations;
        [Abide.Guerilla.Tags.FieldAttribute("spawn time (in seconds, 0 = default)", typeof(Int16))]
        public Int16 SpawnTimeInSeconds0EqualsDefault;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
    }
}
#pragma warning restore CS1591
