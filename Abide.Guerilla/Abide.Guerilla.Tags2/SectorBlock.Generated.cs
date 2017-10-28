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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
    public class SectorBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Path-finding sector flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(PathfindingSectorFlagsOptions), true)]
        public Int16 PathfindingSectorFlags;
        [Abide.Guerilla.Tags.FieldAttribute("hint index", typeof(Int16))]
        public Int16 HintIndex;
        [Abide.Guerilla.Tags.FieldAttribute("first link (do not set manually)", typeof(Int32))]
        public Int32 FirstLinkDoNotSetManually;
        public enum PathfindingSectorFlagsOptions
        {
            SectorWalkable = 1,
            SectorBreakable = 2,
            SectorMobile = 4,
            SectorBspSource = 8,
            Floor = 16,
            Ceiling = 32,
            WallNorth = 64,
            WallSouth = 128,
            WallEast = 256,
            WallWest = 512,
            Crouchable = 1024,
            Aligned = 2048,
            SectorStep = 4096,
            SectorInterior = 8192,
        }
    }
}
#pragma warning restore CS1591
