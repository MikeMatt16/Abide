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
    public class UserHintPolygonBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("Points", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("User Hint Point Block", 200, typeof(UserHintPointBlock))]
        public TagBlock Points;
        public enum FlagsOptions
        {
            Bidirectional = 1,
            Closed = 2,
        }
    }
}
#pragma warning restore CS1591
