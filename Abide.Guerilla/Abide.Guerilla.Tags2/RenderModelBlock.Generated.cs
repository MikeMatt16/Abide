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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(184, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("render_model", "mode", "����", typeof(RenderModelBlock))]
    public class RenderModelBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name*", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("flags*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Flags), true)]
        public Int16 Flags1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("import info*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Import Info", 1, typeof(GlobalTagImportInfoBlock))]
        public TagBlock ImportInfo;
        [Abide.Guerilla.Tags.FieldAttribute("compression info*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Compression Info", 1, typeof(GlobalGeometryCompressionInfoBlock))]
        public TagBlock CompressionInfo;
        [Abide.Guerilla.Tags.FieldAttribute("regions*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Region", 16, typeof(RenderModelRegionBlock))]
        public TagBlock Regions;
        [Abide.Guerilla.Tags.FieldAttribute("sections*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Render Model Section Block", 255, typeof(RenderModelSectionBlock))]
        public TagBlock Sections;
        [Abide.Guerilla.Tags.FieldAttribute("invalid section pair bits*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Bitvector", 1013, typeof(RenderModelInvalidSectionPairsBlock))]
        public TagBlock InvalidSectionPairBits;
        [Abide.Guerilla.Tags.FieldAttribute("section groups*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Section Group", 6, typeof(RenderModelSectionGroupBlock))]
        public TagBlock SectionGroups;
        [Abide.Guerilla.Tags.FieldAttribute("L1 section group index*:(super low)", typeof(Byte))]
        public Byte L1SectionGroupIndex;
        [Abide.Guerilla.Tags.FieldAttribute("L2 section group index*:(low)", typeof(Byte))]
        public Byte L2SectionGroupIndex;
        [Abide.Guerilla.Tags.FieldAttribute("L3 section group index*:(medium)", typeof(Byte))]
        public Byte L3SectionGroupIndex;
        [Abide.Guerilla.Tags.FieldAttribute("L4 section group index*:(high)", typeof(Byte))]
        public Byte L4SectionGroupIndex;
        [Abide.Guerilla.Tags.FieldAttribute("L5 section group index*:(super high)", typeof(Byte))]
        public Byte L5SectionGroupIndex;
        [Abide.Guerilla.Tags.FieldAttribute("L6 section group index*:(hollywood)", typeof(Byte))]
        public Byte L6SectionGroupIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("node list checksum*", typeof(Int32))]
        public Int32 NodeListChecksum;
        [Abide.Guerilla.Tags.FieldAttribute("nodes*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Node", 255, typeof(RenderModelNodeBlock))]
        public TagBlock Nodes;
        [Abide.Guerilla.Tags.FieldAttribute("node map (OLD)*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Index", 640, typeof(RenderModelNodeMapBlockOLD))]
        public TagBlock NodeMapOld;
        [Abide.Guerilla.Tags.FieldAttribute("marker groups*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Marker Group", 4096, typeof(RenderModelMarkerGroupBlock))]
        public TagBlock MarkerGroups;
        [Abide.Guerilla.Tags.FieldAttribute("materials*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Material", 1024, typeof(GlobalGeometryMaterialBlock))]
        public TagBlock Materials;
        [Abide.Guerilla.Tags.FieldAttribute("errors*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Error Report Category", 64, typeof(GlobalErrorReportCategoriesBlock))]
        public TagBlock Errors;
        [Abide.Guerilla.Tags.FieldAttribute("don\'t draw over camera cosine angle#dont draw fp model when camera > this angle c" +
            "osine (-1,1) Sugg. -0.2. 0 disables.", typeof(Single))]
        public Single DontDrawOverCameraCosineAngle;
        [Abide.Guerilla.Tags.FieldAttribute("PRT info", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Prt Info Block", 1, typeof(PrtInfoBlock))]
        public TagBlock PrtInfo;
        [Abide.Guerilla.Tags.FieldAttribute("section render leaves", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Section Render Leaves Block", 255, typeof(SectionRenderLeavesBlock))]
        public TagBlock SectionRenderLeaves;
        public enum Flags
        {
            RenderModelForceThirdPersonBit = 1,
            ForceCarmackreverse = 2,
            ForceNodeMaps = 4,
            GeometryPostprocessed = 8,
        }
    }
}
#pragma warning restore CS1591
