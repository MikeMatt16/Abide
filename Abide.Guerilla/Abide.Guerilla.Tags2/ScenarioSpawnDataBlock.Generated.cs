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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(108, 4)]
    public class ScenarioSpawnDataBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Dynamic Spawn Lower Height", typeof(Single))]
        public Single DynamicSpawnLowerHeight;
        [Abide.Guerilla.Tags.FieldAttribute("Dynamic Spawn Upper Height", typeof(Single))]
        public Single DynamicSpawnUpperHeight;
        [Abide.Guerilla.Tags.FieldAttribute("Game Object Reset Height", typeof(Single))]
        public Single GameObjectResetHeight;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(60)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("Dynamic Spawn Overloads", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Dynamic Spawn Zone Overload Block", 32, typeof(DynamicSpawnZoneOverloadBlock))]
        public TagBlock DynamicSpawnOverloads;
        [Abide.Guerilla.Tags.FieldAttribute("Static Respawn Zones", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Static Spawn Zone Block", 128, typeof(StaticSpawnZoneBlock))]
        public TagBlock StaticRespawnZones;
        [Abide.Guerilla.Tags.FieldAttribute("Static Initial Spawn Zones", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Static Spawn Zone Block", 128, typeof(StaticSpawnZoneBlock))]
        public TagBlock StaticInitialSpawnZones;
    }
}
#pragma warning restore CS1591
