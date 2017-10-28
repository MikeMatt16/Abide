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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("scenario_trigger_volumes_resource", 1953654570u, 4294967293u, typeof(ScenarioTriggerVolumesResourceBlock))]
    public sealed class ScenarioTriggerVolumesResourceBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("Kill Trigger Volumes", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("scenario_trigger_volume_block", 256, typeof(ScenarioTriggerVolumeBlock))]
        public TagBlock KillTriggerVolumes;
        [Abide.Guerilla.Tags.FieldAttribute("Object Names", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("scenario_object_names_block", 640, typeof(ScenarioObjectNamesBlock))]
        public TagBlock ObjectNames;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(68, 4)]
        public sealed class ScenarioTriggerVolumeBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(StringId))]
            public StringId Name;
            [Abide.Guerilla.Tags.FieldAttribute("Object Name", typeof(Int16))]
            public Int16 ObjectName;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("Node Name", typeof(StringId))]
            public StringId NodeName;
            [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(EmptyStringElement[]))]
            [Abide.Guerilla.Tags.ArrayAttribute(6, typeof(EmptyStringElement))]
            public EmptyStringElement[] EmptyString1;
            [Abide.Guerilla.Tags.FieldAttribute("Position", typeof(Vector3))]
            public Vector3 Position;
            [Abide.Guerilla.Tags.FieldAttribute("Extents", typeof(Vector3))]
            public Vector3 Extents;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(4)]
            public Byte[] EmptyString2;
            [Abide.Guerilla.Tags.FieldAttribute("~Kill Trigger Volume*", typeof(Int16))]
            public Int16 KillTriggerVolume;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString3;
            public int Size
            {
                get
                {
                    return 68;
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
            public sealed class EmptyStringElement : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(Single))]
                public Single EmptyString;
                public int Size
                {
                    get
                    {
                        return 0;
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
    }
}
#pragma warning restore CS1591
