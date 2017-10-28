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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(564, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("cellular_automata", 1684371055u, 4294967293u, typeof(CellularAutomataBlock))]
    public sealed class CellularAutomataBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("updates per second:Hz", typeof(Int16))]
        public Int16 UpdatesPerSecond;
        [Abide.Guerilla.Tags.FieldAttribute("x (width):cells", typeof(Int16))]
        public Int16 XWidth;
        [Abide.Guerilla.Tags.FieldAttribute("y (depth):cells", typeof(Int16))]
        public Int16 YDepth;
        [Abide.Guerilla.Tags.FieldAttribute("z (height):cells", typeof(Int16))]
        public Int16 ZHeight;
        [Abide.Guerilla.Tags.FieldAttribute("x (width):world units", typeof(Single))]
        public Single XWidth1;
        [Abide.Guerilla.Tags.FieldAttribute("y (depth):world units", typeof(Single))]
        public Single YDepth1;
        [Abide.Guerilla.Tags.FieldAttribute("z (height):world units", typeof(Single))]
        public Single ZHeight1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("marker", typeof(StringId))]
        public StringId Marker;
        [Abide.Guerilla.Tags.FieldAttribute("cell birth chance:[0,1]", typeof(Single))]
        public Single CellBirthChance;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("cell gene mutates 1 in:times", typeof(Int32))]
        public Int32 CellGeneMutates1In;
        [Abide.Guerilla.Tags.FieldAttribute("virus gene mutations 1 in:times", typeof(Int32))]
        public Int32 VirusGeneMutations1In;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("minimum infection age:updates#no cell can be infected before it has been alive th" +
            "is number of updates", typeof(Int16))]
        public Int16 MinimumInfectionAge;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("cell infection chance:[0,1]", typeof(Single))]
        public Single CellInfectionChance;
        [Abide.Guerilla.Tags.FieldAttribute("infection threshold:[0,1]#0.0 is most difficult for the virus, 1.0 means any viru" +
            "s can infect any cell", typeof(Single))]
        public Single InfectionThreshold;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("new cell filled chance:[0,1]", typeof(Single))]
        public Single NewCellFilledChance;
        [Abide.Guerilla.Tags.FieldAttribute("new cell infected chance:[0,1]", typeof(Single))]
        public Single NewCellInfectedChance;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("detail texture change chance:[0,1]", typeof(Single))]
        public Single DetailTextureChangeChance;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString6;
        [Abide.Guerilla.Tags.FieldAttribute("detail texture width:cells#the number of cells repeating across the detail textur" +
            "e in both dimensions", typeof(Int16))]
        public Int16 DetailTextureWidth;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString7;
        [Abide.Guerilla.Tags.FieldAttribute("detail texture", typeof(TagReference))]
        public TagReference DetailTexture1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString8;
        [Abide.Guerilla.Tags.FieldAttribute("mask bitmap", typeof(TagReference))]
        public TagReference MaskBitmap;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(240)]
        public Byte[] EmptyString9;
        public int Size
        {
            get
            {
                return 564;
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
#pragma warning restore CS1591
