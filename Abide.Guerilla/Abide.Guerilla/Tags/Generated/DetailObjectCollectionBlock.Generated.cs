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
    using System.IO;
    
    [FieldSetAttribute(128, 4)]
    [TagGroupAttribute("detail_object_collection", 1685021283u, 4294967293u, typeof(DetailObjectCollectionBlock))]
    public sealed class DetailObjectCollectionBlock : AbideTagBlock
    {
        private TagBlockList<DetailObjectTypeBlock> typesList = new TagBlockList<DetailObjectTypeBlock>(16);
        [FieldAttribute("Collection Type", typeof(CollectionTypeOptions))]
        [OptionsAttribute(typeof(CollectionTypeOptions), false)]
        public CollectionTypeOptions CollectionType;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(2)]
        public Byte[] EmptyString;
        [FieldAttribute("Global z Offset: Applied to all detail objects in this collection so they don\'t f" +
            "loat above the ground.", typeof(Single))]
        public Single GlobalZOffset;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(44)]
        public Byte[] EmptyString1;
        [FieldAttribute("Sprite Plate", typeof(TagReference))]
        public TagReference SpritePlate;
        [FieldAttribute("Types", typeof(TagBlock))]
        [BlockAttribute("detail_object_type_block", 16, typeof(DetailObjectTypeBlock))]
        public TagBlock Types;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(48)]
        public Byte[] EmptyString2;
        public TagBlockList<DetailObjectTypeBlock> TypesList
        {
            get
            {
                return this.typesList;
            }
        }
        public override int Size
        {
            get
            {
                return 128;
            }
        }
        public override void Initialize()
        {
            this.typesList.Clear();
            this.CollectionType = ((CollectionTypeOptions)(0));
            this.EmptyString = new byte[2];
            this.GlobalZOffset = 0;
            this.EmptyString1 = new byte[44];
            this.SpritePlate = TagReference.Null;
            this.Types = TagBlock.Zero;
            this.EmptyString2 = new byte[48];
        }
        public override void Read(BinaryReader reader)
        {
            this.CollectionType = ((CollectionTypeOptions)(reader.ReadInt16()));
            this.EmptyString = reader.ReadBytes(2);
            this.GlobalZOffset = reader.ReadSingle();
            this.EmptyString1 = reader.ReadBytes(44);
            this.SpritePlate = reader.Read<TagReference>();
            this.Types = reader.ReadInt64();
            this.typesList.Read(reader, this.Types);
            this.EmptyString2 = reader.ReadBytes(48);
        }
        public override void Write(BinaryWriter writer)
        {
        }
        [FieldSetAttribute(96, 4)]
        public sealed class DetailObjectTypeBlock : AbideTagBlock
        {
            [FieldAttribute("Name^", typeof(String32))]
            public String32 Name;
            [FieldAttribute("Sequence Index:[0,15]", typeof(Byte))]
            public Byte SequenceIndex;
            [FieldAttribute("type flags", typeof(TypeFlagsOptions))]
            [OptionsAttribute(typeof(TypeFlagsOptions), true)]
            public TypeFlagsOptions TypeFlags;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(2)]
            public Byte[] EmptyString;
            [FieldAttribute("Color Override Factor#Fraction of detail object color to use instead of the base " +
                "map color in the environment:[0,1]", typeof(Single))]
            public Single ColorOverrideFactor;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(8)]
            public Byte[] EmptyString1;
            [FieldAttribute("Near Fade Distance:world units", typeof(Single))]
            public Single NearFadeDistance;
            [FieldAttribute("Far Fade Distance:world units", typeof(Single))]
            public Single FarFadeDistance;
            [FieldAttribute("Size:world units per pixel", typeof(Single))]
            public Single Size1;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(4)]
            public Byte[] EmptyString2;
            [FieldAttribute("Minimum Color:[0,1]", typeof(ColorRgbF))]
            public ColorRgbF MinimumColor;
            [FieldAttribute("Maximum Color:[0,1]", typeof(ColorRgbF))]
            public ColorRgbF MaximumColor;
            [FieldAttribute("ambient color:[0,255]", typeof(ColorArgb))]
            public ColorArgb AmbientColor;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(4)]
            public Byte[] EmptyString3;
            public override int Size
            {
                get
                {
                    return 96;
                }
            }
            public override void Initialize()
            {
                this.Name = String32.Empty;
                this.SequenceIndex = 0;
                this.TypeFlags = ((TypeFlagsOptions)(0));
                this.EmptyString = new byte[2];
                this.ColorOverrideFactor = 0;
                this.EmptyString1 = new byte[8];
                this.NearFadeDistance = 0;
                this.FarFadeDistance = 0;
                this.Size1 = 0;
                this.EmptyString2 = new byte[4];
                this.MinimumColor = ColorRgbF.Zero;
                this.MaximumColor = ColorRgbF.Zero;
                this.AmbientColor = ColorArgb.Zero;
                this.EmptyString3 = new byte[4];
            }
            public override void Read(BinaryReader reader)
            {
                this.Name = reader.Read<String32>();
                this.SequenceIndex = reader.ReadByte();
                this.TypeFlags = ((TypeFlagsOptions)(reader.ReadByte()));
                this.EmptyString = reader.ReadBytes(2);
                this.ColorOverrideFactor = reader.ReadSingle();
                this.EmptyString1 = reader.ReadBytes(8);
                this.NearFadeDistance = reader.ReadSingle();
                this.FarFadeDistance = reader.ReadSingle();
                this.Size1 = reader.ReadSingle();
                this.EmptyString2 = reader.ReadBytes(4);
                this.MinimumColor = reader.Read<ColorRgbF>();
                this.MaximumColor = reader.Read<ColorRgbF>();
                this.AmbientColor = reader.Read<ColorArgb>();
                this.EmptyString3 = reader.ReadBytes(4);
            }
            public override void Write(BinaryWriter writer)
            {
            }
            public enum TypeFlagsOptions : Byte
            {
                Unused = 1,
                Unused1 = 2,
                InterpolateColorInHsv = 4,
                MoreColors = 8,
            }
        }
        public enum CollectionTypeOptions : Int16
        {
            ScreenFacing = 0,
            ViewerFacing = 1,
        }
    }
}
#pragma warning restore CS1591