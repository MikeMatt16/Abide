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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(88, 4)]
    public class StructureBspInstancedGeometryInstancesBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Scale", typeof(Single))]
        public Single Scale;
        [Abide.Guerilla.Tags.FieldAttribute("Forward", typeof(Vector3))]
        public Vector3 Forward;
        [Abide.Guerilla.Tags.FieldAttribute("Left", typeof(Vector3))]
        public Vector3 Left;
        [Abide.Guerilla.Tags.FieldAttribute("Up", typeof(Vector3))]
        public Vector3 Up;
        [Abide.Guerilla.Tags.FieldAttribute("Position", typeof(Vector3))]
        public Vector3 Position;
        [Abide.Guerilla.Tags.FieldAttribute("Instance Definition*", typeof(Int16))]
        public Int16 InstanceDefinition;
        [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("Checksum*", typeof(Int32))]
        public Int32 Checksum;
        [Abide.Guerilla.Tags.FieldAttribute("Name*^", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("Pathfinding Policy*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(PathfindingPolicy), false)]
        public Int16 PathfindingPolicy1;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmapping Policy*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(LightmappingPolicy), false)]
        public Int16 LightmappingPolicy1;
        public enum FlagsOptions
        {
            NotInLightprobes = 1,
        }
        public enum PathfindingPolicy
        {
            Cutout = 0,
            Static = 1,
            None = 2,
        }
        public enum LightmappingPolicy
        {
            PerPixel = 0,
            PerVertex = 1,
        }
    }
}
#pragma warning restore CS1591
