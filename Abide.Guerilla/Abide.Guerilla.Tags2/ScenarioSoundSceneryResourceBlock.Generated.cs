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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(76, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("scenario_sound_scenery_resource", "*sce", "����", typeof(ScenarioSoundSceneryResourceBlock))]
    public class ScenarioSoundSceneryResourceBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Names", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Scenario Object Names Block", 640, typeof(ScenarioObjectNamesBlock))]
        public TagBlock Names;
        [Abide.Guerilla.Tags.FieldAttribute("*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Dont Use Me Scenario Environment Object Block", 4096, typeof(DontUseMeScenarioEnvironmentObjectBlock))]
        public TagBlock EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("Structure References", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Scenario Structure Bsp Reference Block", 16, typeof(ScenarioStructureBspReferenceBlock))]
        public TagBlock StructureReferences;
        [Abide.Guerilla.Tags.FieldAttribute("Palette", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Scenario Sound Scenery Palette Block", 256, typeof(ScenarioSoundSceneryPaletteBlock))]
        public TagBlock Palette;
        [Abide.Guerilla.Tags.FieldAttribute("Objects", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Scenario Sound Scenery Block", 256, typeof(ScenarioSoundSceneryBlock))]
        public TagBlock Objects;
        [Abide.Guerilla.Tags.FieldAttribute("Next Object ID Salt*", typeof(Int32))]
        public Int32 NextObjectIdSalt;
        [Abide.Guerilla.Tags.FieldAttribute("Editor Folders*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("G Scenario Editor Folder Block", 32767, typeof(GScenarioEditorFolderBlock))]
        public TagBlock EditorFolders;
    }
}
#pragma warning restore CS1591
