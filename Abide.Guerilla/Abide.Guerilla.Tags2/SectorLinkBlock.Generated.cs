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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(16, 4)]
    public class SectorLinkBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("vertex 1", typeof(Int16))]
        public Int16 Vertex1;
        [Abide.Guerilla.Tags.FieldAttribute("vertex 2", typeof(Int16))]
        public Int16 Vertex2;
        [Abide.Guerilla.Tags.FieldAttribute("link flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(LinkFlagsOptions), true)]
        public Int16 LinkFlags;
        [Abide.Guerilla.Tags.FieldAttribute("hint index", typeof(Int16))]
        public Int16 HintIndex;
        [Abide.Guerilla.Tags.FieldAttribute("forward link", typeof(Int16))]
        public Int16 ForwardLink;
        [Abide.Guerilla.Tags.FieldAttribute("reverse link", typeof(Int16))]
        public Int16 ReverseLink;
        [Abide.Guerilla.Tags.FieldAttribute("left sector", typeof(Int16))]
        public Int16 LeftSector;
        [Abide.Guerilla.Tags.FieldAttribute("right sector", typeof(Int16))]
        public Int16 RightSector;
        public enum LinkFlagsOptions
        {
            SectorLinkFromCollisionEdge = 1,
            SectorIntersectionLink = 2,
            SectorLinkBsp2dCreationError = 4,
            SectorLinkTopologyError = 8,
            SectorLinkChainError = 16,
            SectorLinkBothSectorsWalkable = 32,
            SectorLinkMagicHangingLink = 64,
            SectorLinkThreshold = 128,
            SectorLinkCrouchable = 256,
            SectorLinkWallBase = 512,
            SectorLinkLedge = 1024,
            SectorLinkLeanable = 2048,
            SectorLinkStartCorner = 4096,
            SectorLinkEndCorner = 8192,
        }
    }
}
#pragma warning restore CS1591
