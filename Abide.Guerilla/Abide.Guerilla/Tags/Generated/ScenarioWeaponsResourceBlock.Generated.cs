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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(76, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("scenario_weapons_resource", 711287152u, 4294967293u, typeof(ScenarioWeaponsResourceBlock))]
    public sealed class ScenarioWeaponsResourceBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("Names", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("scenario_object_names_block", 640, typeof(ScenarioObjectNamesBlock))]
        public TagBlock Names;
        [Abide.Guerilla.Tags.FieldAttribute("*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("dont_use_me_scenario_environment_object_block", 4096, typeof(DontUseMeScenarioEnvironmentObjectBlock))]
        public TagBlock EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("Structure References", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("scenario_structure_bsp_reference_block", 16, typeof(ScenarioStructureBspReferenceBlock))]
        public TagBlock StructureReferences;
        [Abide.Guerilla.Tags.FieldAttribute("Palette", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("scenario_weapon_palette_block", 256, typeof(ScenarioWeaponPaletteBlock))]
        public TagBlock Palette;
        [Abide.Guerilla.Tags.FieldAttribute("Objects", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("scenario_weapon_block", 128, typeof(ScenarioWeaponBlock))]
        public TagBlock Objects;
        [Abide.Guerilla.Tags.FieldAttribute("Next Object ID Salt*", typeof(Int32))]
        public Int32 NextObjectIdSalt;
        [Abide.Guerilla.Tags.FieldAttribute("Editor Folders*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("g_scenario_editor_folder_block", 32767, typeof(GScenarioEditorFolderBlock))]
        public TagBlock EditorFolders;
        public int Size
        {
            get
            {
                return 76;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(36, 4)]
        public sealed class ScenarioObjectNamesBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(String32))]
            public String32 Name;
            [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(Int16))]
            public Int16 EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(Int16))]
            public Int16 EmptyString1;
            public int Size
            {
                get
                {
                    return 36;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(64, 4)]
        public sealed class DontUseMeScenarioEnvironmentObjectBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("BSP*", typeof(Int16))]
            public Int16 Bsp;
            [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(Int16))]
            public Int16 EmptyString1;
            [Abide.Guerilla.Tags.FieldAttribute("Unique ID*", typeof(Int32))]
            public Int32 UniqueId;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(4)]
            public Byte[] EmptyString2;
            [Abide.Guerilla.Tags.FieldAttribute("Object Definition Tag*", typeof(Tag))]
            public Tag ObjectDefinitionTag;
            [Abide.Guerilla.Tags.FieldAttribute("Object*^", typeof(Int32))]
            public Int32 Object;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(44)]
            public Byte[] EmptyString3;
            public int Size
            {
                get
                {
                    return 64;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(84, 4)]
        public sealed class ScenarioStructureBspReferenceBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(16)]
            public Byte[] EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("Structure BSP^", typeof(TagReference))]
            public TagReference StructureBsp;
            [Abide.Guerilla.Tags.FieldAttribute("Structure Lightmap^", typeof(TagReference))]
            public TagReference StructureLightmap;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(4)]
            public Byte[] EmptyString1;
            [Abide.Guerilla.Tags.FieldAttribute("UNUSED radiance est. search distance", typeof(Single))]
            public Single UnusedRadianceEstSearchDistance;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(4)]
            public Byte[] EmptyString2;
            [Abide.Guerilla.Tags.FieldAttribute("UNUSED luminels per world unit", typeof(Single))]
            public Single UnusedLuminelsPerWorldUnit;
            [Abide.Guerilla.Tags.FieldAttribute("UNUSED output white reference", typeof(Single))]
            public Single UnusedOutputWhiteReference;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(8)]
            public Byte[] EmptyString3;
            [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
            public Int16 Flags;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString4;
            [Abide.Guerilla.Tags.FieldAttribute("Default Sky", typeof(Int16))]
            public Int16 DefaultSky;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString5;
            public int Size
            {
                get
                {
                    return 84;
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
            public enum FlagsOptions
            {
                DefaultSkyEnabled = 1,
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(48, 4)]
        public sealed class ScenarioWeaponPaletteBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(TagReference))]
            public TagReference Name;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(32)]
            public Byte[] EmptyString;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(84, 4)]
        public sealed class ScenarioWeaponBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Type", typeof(Int16))]
            public Int16 Type;
            [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(Int16))]
            public Int16 Name;
            [Abide.Guerilla.Tags.FieldAttribute("Object Data", typeof(ScenarioObjectDatumStructBlock))]
            public ScenarioObjectDatumStructBlock ObjectData;
            [Abide.Guerilla.Tags.FieldAttribute("Permutation Data", typeof(ScenarioObjectPermutationStructBlock))]
            public ScenarioObjectPermutationStructBlock PermutationData;
            [Abide.Guerilla.Tags.FieldAttribute("Weapon Data", typeof(ScenarioWeaponDatumStructBlock))]
            public ScenarioWeaponDatumStructBlock WeaponData;
            public int Size
            {
                get
                {
                    return 84;
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
            public sealed class ScenarioObjectDatumStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("Placement Flags", typeof(Int32))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(PlacementFlagsOptions), true)]
                public Int32 PlacementFlags;
                [Abide.Guerilla.Tags.FieldAttribute("Position", typeof(Vector3))]
                public Vector3 Position;
                [Abide.Guerilla.Tags.FieldAttribute("Rotation", typeof(Vector3))]
                public Vector3 Rotation;
                [Abide.Guerilla.Tags.FieldAttribute("Scale", typeof(Single))]
                public Single Scale;
                [Abide.Guerilla.Tags.FieldAttribute(")Transform Flags", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(TransformFlagsOptions), true)]
                public Int16 TransformFlags;
                [Abide.Guerilla.Tags.FieldAttribute("Manual BSP Flags*", typeof(Int16))]
                public Int16 ManualBspFlags;
                [Abide.Guerilla.Tags.FieldAttribute("Object ID", typeof(ScenarioObjectIdStructBlock))]
                public ScenarioObjectIdStructBlock ObjectId;
                [Abide.Guerilla.Tags.FieldAttribute("BSP Policy", typeof(Byte))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(BspPolicyOptions), false)]
                public Byte BspPolicy;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(1)]
                public Byte[] EmptyString1;
                [Abide.Guerilla.Tags.FieldAttribute("Editor Folder", typeof(Int16))]
                public Int16 EditorFolder;
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
                [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
                public sealed class ScenarioObjectIdStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                {
                    [Abide.Guerilla.Tags.FieldAttribute("Unique ID*", typeof(Int32))]
                    public Int32 UniqueId;
                    [Abide.Guerilla.Tags.FieldAttribute("Origin BSP Index*", typeof(Int16))]
                    public Int16 OriginBspIndex;
                    [Abide.Guerilla.Tags.FieldAttribute("Type*", typeof(Byte))]
                    [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), false)]
                    public Byte Type;
                    [Abide.Guerilla.Tags.FieldAttribute("Source*", typeof(Byte))]
                    [Abide.Guerilla.Tags.OptionsAttribute(typeof(SourceOptions), false)]
                    public Byte Source;
                    public int Size
                    {
                        get
                        {
                            return 8;
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
                    public enum TypeOptions
                    {
                        Biped = 0,
                        Vehicle = 1,
                        Weapon = 2,
                        Equipment = 3,
                        Garbage = 4,
                        Projectile = 5,
                        Scenery = 6,
                        Machine = 7,
                        Control = 8,
                        LightFixture = 9,
                        SoundScenery = 10,
                        Crate = 11,
                        Creature = 12,
                    }
                    public enum SourceOptions
                    {
                        Structure = 0,
                        Editor = 1,
                        Dynamic = 2,
                        Legacy = 3,
                    }
                }
                public enum PlacementFlagsOptions
                {
                    NotAutomatically = 1,
                    Unused = 2,
                    Unused1 = 4,
                    Unused2 = 8,
                    LockTypeToEnvObject = 16,
                    LockTransformToEnvObject = 32,
                    NeverPlaced = 64,
                    LockNameToEnvObject = 128,
                    CreateAtRest = 256,
                }
                public enum TransformFlagsOptions
                {
                    Mirrored = 1,
                }
                public enum BspPolicyOptions
                {
                    Default = 0,
                    AlwaysPlaced = 1,
                    ManualBspPlacement = 2,
                }
            }
            [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
            public sealed class ScenarioObjectPermutationStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("Variant Name", typeof(StringId))]
                public StringId VariantName;
                [Abide.Guerilla.Tags.FieldAttribute("Active Change Colors", typeof(Int32))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(ActiveChangeColorsOptions), true)]
                public Int32 ActiveChangeColors;
                [Abide.Guerilla.Tags.FieldAttribute("Primary Color", typeof(ColorRgb))]
                public ColorRgb PrimaryColor;
                [Abide.Guerilla.Tags.FieldAttribute("Secondary Color", typeof(ColorRgb))]
                public ColorRgb SecondaryColor;
                [Abide.Guerilla.Tags.FieldAttribute("Tertiary Color", typeof(ColorRgb))]
                public ColorRgb TertiaryColor;
                [Abide.Guerilla.Tags.FieldAttribute("Quaternary Color", typeof(ColorRgb))]
                public ColorRgb QuaternaryColor;
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
                public enum ActiveChangeColorsOptions
                {
                    Primary = 1,
                    Secondary = 2,
                    Tertiary = 4,
                    Quaternary = 8,
                }
            }
            [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
            public sealed class ScenarioWeaponDatumStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("Rounds Left", typeof(Int16))]
                public Int16 RoundsLeft;
                [Abide.Guerilla.Tags.FieldAttribute("Rounds Loaded", typeof(Int16))]
                public Int16 RoundsLoaded;
                [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int32))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
                public Int32 Flags;
                public int Size
                {
                    get
                    {
                        return 8;
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
                public enum FlagsOptions
                {
                    InitiallyAtRestDoesNotFall = 1,
                    Obsolete = 2,
                    DoesAccelerateMovesDueToExplosions = 4,
                }
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(260, 4)]
        public sealed class GScenarioEditorFolderBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("parent folder", typeof(Int32))]
            public Int32 ParentFolder;
            [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(String256))]
            public String256 Name;
            public int Size
            {
                get
                {
                    return 260;
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
