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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(104, 4)]
    public class RenderModelSectionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("global_geometry_classification_enum_definition", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(GlobalGeometryClassificationEnumDefinitionOptions), false)]
        public Int16 GlobalGeometryClassificationEnumDefinition;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("section info*", typeof(GlobalGeometrySectionInfoStructBlock))]
        public GlobalGeometrySectionInfoStructBlock SectionInfo;
        [Abide.Guerilla.Tags.FieldAttribute("rigid node*", typeof(Int16))]
        public Int16 RigidNode;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("section data*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Render Model Section Data Block", 1, typeof(RenderModelSectionDataBlock))]
        public TagBlock SectionData;
        [Abide.Guerilla.Tags.FieldAttribute("geometry block info*", typeof(GlobalGeometryBlockInfoStructBlock))]
        public GlobalGeometryBlockInfoStructBlock GeometryBlockInfo;
        public enum GlobalGeometryClassificationEnumDefinitionOptions
        {
            Worldspace = 0,
            Rigid = 1,
            RigidBoned = 2,
            Skinned = 3,
            UnsupportedReimport = 4,
        }
        public enum FlagsOptions
        {
            GeometryPostprocessed = 1,
        }
    }
}
#pragma warning restore CS1591
