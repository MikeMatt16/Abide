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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(196, 4)]
    public class GlobalGeometrySectionRawVertexBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Position*", typeof(Vector3))]
        public Vector3 Position;
        [Abide.Guerilla.Tags.FieldAttribute("Node Indices (OLD)*", typeof(Byte[]))]
        public Byte[] NodeIndicesOld;
        [Abide.Guerilla.Tags.FieldAttribute("Node Index (OLD)*", typeof(Int32))]
        public Int32 NodeIndexOld;
        [Abide.Guerilla.Tags.FieldAttribute("Node Weights*", typeof(Byte[]))]
        public Byte[] NodeWeights;
        [Abide.Guerilla.Tags.FieldAttribute("node_weight*", typeof(Single))]
        public Single NodeWeight;
        [Abide.Guerilla.Tags.FieldAttribute("Node Indices (NEW)*", typeof(Byte[]))]
        public Byte[] NodeIndicesNew;
        [Abide.Guerilla.Tags.FieldAttribute("Node Index (NEW)*", typeof(Int32))]
        public Int32 NodeIndexNew;
        [Abide.Guerilla.Tags.FieldAttribute("Use New Node Indices*", typeof(Int32))]
        public Int32 UseNewNodeIndices;
        [Abide.Guerilla.Tags.FieldAttribute("Adjusted Compound Node Index*", typeof(Int32))]
        public Int32 AdjustedCompoundNodeIndex;
        [Abide.Guerilla.Tags.FieldAttribute("texcoord*", typeof(Vector2))]
        public Vector2 Texcoord;
        [Abide.Guerilla.Tags.FieldAttribute("Normal*", typeof(Vector3))]
        public Vector3 Normal;
        [Abide.Guerilla.Tags.FieldAttribute("Binormal*", typeof(Vector3))]
        public Vector3 Binormal;
        [Abide.Guerilla.Tags.FieldAttribute("Tangent*", typeof(Vector3))]
        public Vector3 Tangent;
        [Abide.Guerilla.Tags.FieldAttribute("Anisotropic Binormal*", typeof(Vector3))]
        public Vector3 AnisotropicBinormal;
        [Abide.Guerilla.Tags.FieldAttribute("Secondary texcoord*", typeof(Vector2))]
        public Vector2 SecondaryTexcoord;
        [Abide.Guerilla.Tags.FieldAttribute("Primary Lightmap Color", typeof(ColorRgbF))]
        public ColorRgbF PrimaryLightmapColor;
        [Abide.Guerilla.Tags.FieldAttribute("Primary Lightmap texcoord", typeof(Vector2))]
        public Vector2 PrimaryLightmapTexcoord;
        [Abide.Guerilla.Tags.FieldAttribute("Primary Lightmap Incident Direction", typeof(Vector3))]
        public Vector3 PrimaryLightmapIncidentDirection;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(8)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString5;
    }
}
#pragma warning restore CS1591
