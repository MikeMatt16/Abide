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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("color_table", 1668246639u, 4294967293u, typeof(ColorTableBlock))]
    public sealed class ColorTableBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("colors", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("color_block", 512, typeof(ColorBlock))]
        public TagBlock Colors;
        public int Size
        {
            get
            {
                return 12;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(48, 4)]
        public sealed class ColorBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(String32))]
            public String32 Name;
            [Abide.Guerilla.Tags.FieldAttribute("color", typeof(ColorArgbF))]
            public ColorArgbF Color;
            public int Size
            {
                get
                {
                    return 48;
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
