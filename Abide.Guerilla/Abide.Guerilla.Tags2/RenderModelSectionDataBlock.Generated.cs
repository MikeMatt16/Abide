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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(180, 4)]
    public class RenderModelSectionDataBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("section*", typeof(GlobalGeometrySectionStructBlock))]
        public GlobalGeometrySectionStructBlock Section;
        [Abide.Guerilla.Tags.FieldAttribute("point data*", typeof(GlobalGeometryPointDataStructBlock))]
        public GlobalGeometryPointDataStructBlock PointData;
        [Abide.Guerilla.Tags.FieldAttribute("node map*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Index", 40, typeof(RenderModelNodeMapBlock))]
        public TagBlock NodeMap;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString;
    }
}
#pragma warning restore CS1591