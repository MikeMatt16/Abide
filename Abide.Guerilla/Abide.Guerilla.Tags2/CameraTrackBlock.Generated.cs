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
    [Abide.Guerilla.Tags.TagGroupAttribute("camera_track", "trak", "����", typeof(CameraTrackBlock))]
    public class CameraTrackBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("control points", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Camera Track Control Point Block", 16, typeof(CameraTrackControlPointBlock))]
        public TagBlock ControlPoints;
        public enum FlagsOptions
        {
        }
    }
}
#pragma warning restore CS1591
