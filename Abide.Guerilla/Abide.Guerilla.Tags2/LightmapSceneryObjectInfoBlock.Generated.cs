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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    public class LightmapSceneryObjectInfoBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("unique ID", typeof(Int32))]
        public Int32 UniqueId;
        [Abide.Guerilla.Tags.FieldAttribute("origin BSP index", typeof(Int16))]
        public Int16 OriginBspIndex;
        [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Byte))]
        public Byte Type;
        [Abide.Guerilla.Tags.FieldAttribute("source", typeof(Byte))]
        public Byte Source;
        [Abide.Guerilla.Tags.FieldAttribute("render model checksum", typeof(Int32))]
        public Int32 RenderModelChecksum;
    }
}
#pragma warning restore CS1591
