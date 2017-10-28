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

namespace Abide.Guerilla.Tags
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(16, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("vehicle_collection", 1986357347u, 4294967293u, typeof(VehicleCollectionBlock))]
    public sealed class VehicleCollectionBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("vehicle permutations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("vehicle_permutation", 32, typeof(VehiclePermutation))]
        public TagBlock VehiclePermutations;
        [Abide.Guerilla.Tags.FieldAttribute("spawn time (in seconds, 0 = default)", typeof(Int16))]
        public Int16 SpawnTimeInSeconds0EqualsDefault;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        public int Size
        {
            get
            {
                return 16;
            }
        }
        public void Initialize()
        {
        }
        public void Read(System.IO.BinaryReader reader)
        {
        }
        public void Write(System.IO.BinaryWriter writer)
        {
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
        public sealed class VehiclePermutation : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("weight#relatively how likely this vehicle will be chosen", typeof(Single))]
            public Single Weight;
            [Abide.Guerilla.Tags.FieldAttribute("vehicle^#which vehicle to ", typeof(TagReference))]
            public TagReference Vehicle;
            [Abide.Guerilla.Tags.FieldAttribute("variant name", typeof(StringId))]
            public StringId VariantName;
            public int Size
            {
                get
                {
                    return 24;
                }
            }
            public void Initialize()
            {
            }
            public void Read(System.IO.BinaryReader reader)
            {
            }
            public void Write(System.IO.BinaryWriter writer)
            {
            }
        }
    }
}
#pragma warning restore CS1591
