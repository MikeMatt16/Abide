//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated scenario_block tag block.
    /// </summary>
    public sealed class ScenarioBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioBlock"/> class.
        /// </summary>
        public ScenarioBlock()
        {
            this.Fields.Add(new TagReferenceField("Do not use.", 1935831920));
            this.Fields.Add(new BlockField<ScenarioSkyReferenceBlock>("Skies", 32));
            this.Fields.Add(new EnumField("Type", "", "Multiplayer", "", "", ""));
            this.Fields.Add(new WordFlagsField("Flags", "Cortana Hack#Sorts Cortana in front of other transparent geometry.", "Always Draw Sky#Always draws sky 0, even if no +sky polygons are visible.", "Don\'t Strip Pathfinding#Always leaves pathfinding in, even for multiplayer scenar" +
                        "io.", "Symmetric Multiplayer Map", "Quick-Loading (Cinematic-Only) Scenario", "Characters Use Previous Mission Weapons", "Lightmaps Smooth Palettes with Neighbors", "Snap to White at Start"));
            this.Fields.Add(new BlockField<ScenarioChildScenarioBlock>("@child scenarios", 16));
            this.Fields.Add(new AngleField("Local North"));
            this.Fields.Add(new BlockField<PredictedResourceBlock>("Predicted Resources*", 2048));
            this.Fields.Add(new BlockField<ScenarioFunctionBlock>("Functions", 32));
            this.Fields.Add(new DataField("Editor Scenario Data", 1, 4));
            this.Fields.Add(new BlockField<EditorCommentBlock>("Comments", 65536));
            this.Fields.Add(new BlockField<DontUseMeScenarioEnvironmentObjectBlock>("*", 4096));
            this.Fields.Add(new BlockField<ScenarioObjectNamesBlock>("Object Names*", 640));
            this.Fields.Add(new BlockField<ScenarioSceneryBlock>("Scenery", 2000));
            this.Fields.Add(new BlockField<ScenarioSceneryPaletteBlock>("Scenery Palette", 256));
            this.Fields.Add(new BlockField<ScenarioBipedBlock>("Bipeds", 128));
            this.Fields.Add(new BlockField<ScenarioBipedPaletteBlock>("Biped Palette", 256));
            this.Fields.Add(new BlockField<ScenarioVehicleBlock>("Vehicles", 256));
            this.Fields.Add(new BlockField<ScenarioVehiclePaletteBlock>("Vehicle Palette", 256));
            this.Fields.Add(new BlockField<ScenarioEquipmentBlock>("Equipment", 256));
            this.Fields.Add(new BlockField<ScenarioEquipmentPaletteBlock>("Equipment Palette", 256));
            this.Fields.Add(new BlockField<ScenarioWeaponBlock>("Weapons", 128));
            this.Fields.Add(new BlockField<ScenarioWeaponPaletteBlock>("Weapon Palette", 256));
            this.Fields.Add(new BlockField<DeviceGroupBlock>("Device Groups", 128));
            this.Fields.Add(new BlockField<ScenarioMachineBlock>("Machines", 400));
            this.Fields.Add(new BlockField<ScenarioMachinePaletteBlock>("Machine Palette", 256));
            this.Fields.Add(new BlockField<ScenarioControlBlock>("Controls", 100));
            this.Fields.Add(new BlockField<ScenarioControlPaletteBlock>("Control Palette", 256));
            this.Fields.Add(new BlockField<ScenarioLightFixtureBlock>("Light Fixtures", 500));
            this.Fields.Add(new BlockField<ScenarioLightFixturePaletteBlock>("Light Fixtures Palette", 256));
            this.Fields.Add(new BlockField<ScenarioSoundSceneryBlock>("Sound Scenery", 256));
            this.Fields.Add(new BlockField<ScenarioSoundSceneryPaletteBlock>("Sound Scenery Palette", 256));
            this.Fields.Add(new BlockField<ScenarioLightBlock>("Light Volumes", 500));
            this.Fields.Add(new BlockField<ScenarioLightPaletteBlock>("Light Volumes Palette", 256));
            this.Fields.Add(new BlockField<ScenarioProfilesBlock>("Player Starting Profile", 256));
            this.Fields.Add(new BlockField<ScenarioPlayersBlock>("Player Starting Locations", 256));
            this.Fields.Add(new BlockField<ScenarioTriggerVolumeBlock>("Kill Trigger Volumes", 256));
            this.Fields.Add(new BlockField<RecordedAnimationBlock>("Recorded Animations", 1024));
            this.Fields.Add(new BlockField<ScenarioNetpointsBlock>("Netgame Flags", 200));
            this.Fields.Add(new BlockField<ScenarioNetgameEquipmentBlock>("Netgame Equipment", 100));
            this.Fields.Add(new BlockField<ScenarioStartingEquipmentBlock>("Starting Equipment", 200));
            this.Fields.Add(new BlockField<ScenarioBspSwitchTriggerVolumeBlock>("BSP Switch Trigger Volumes", 256));
            this.Fields.Add(new BlockField<ScenarioDecalsBlock>("Decals", 65536));
            this.Fields.Add(new BlockField<ScenarioDecalPaletteBlock>("Decals Palette", 128));
            this.Fields.Add(new BlockField<ScenarioDetailObjectCollectionPaletteBlock>("Detail Object Collection Palette", 32));
            this.Fields.Add(new BlockField<StylePaletteBlock>("Style Palette", 50));
            this.Fields.Add(new BlockField<SquadGroupsBlock>("Squad Groups", 100));
            this.Fields.Add(new BlockField<SquadsBlock>("Squads", 335));
            this.Fields.Add(new BlockField<ZoneBlock>("Zones", 128));
            this.Fields.Add(new BlockField<AiSceneBlock>("Mission Scenes", 100));
            this.Fields.Add(new BlockField<CharacterPaletteBlock>("Character Palette", 64));
            this.Fields.Add(new BlockField<PathfindingDataBlock>("AI Pathfinding Data", 16));
            this.Fields.Add(new BlockField<AiAnimationReferenceBlock>("AI Animation References", 128));
            this.Fields.Add(new BlockField<AiScriptReferenceBlock>("AI Script References", 128));
            this.Fields.Add(new BlockField<AiRecordingReferenceBlock>("AI Recording References", 128));
            this.Fields.Add(new BlockField<AiConversationBlock>("AI Conversations", 128));
            this.Fields.Add(new DataField("Script Syntax Data", 1, 4));
            this.Fields.Add(new DataField("Script String Data", 1, 4));
            this.Fields.Add(new BlockField<HsScriptsBlock>("Scripts*", 1024));
            this.Fields.Add(new BlockField<HsGlobalsBlock>("Globals*", 256));
            this.Fields.Add(new BlockField<HsReferencesBlock>("References*", 512));
            this.Fields.Add(new BlockField<HsSourceFilesBlock>("Source Files*", 8));
            this.Fields.Add(new BlockField<CsScriptDataBlock>("Scripting Data", 1));
            this.Fields.Add(new BlockField<ScenarioCutsceneFlagBlock>("Cutscene Flags", 512));
            this.Fields.Add(new BlockField<ScenarioCutsceneCameraPointBlock>("Cutscene Camera Points", 512));
            this.Fields.Add(new BlockField<ScenarioCutsceneTitleBlock>("Cutscene Titles", 128));
            this.Fields.Add(new TagReferenceField("Custom Object Names", 1970170211));
            this.Fields.Add(new TagReferenceField("Chapter Title Text", 1970170211));
            this.Fields.Add(new TagReferenceField("HUD Messages", 1752003616));
            this.Fields.Add(new BlockField<ScenarioStructureBspReferenceBlock>("Structure BSPs", 16));
            this.Fields.Add(new BlockField<ScenarioResourcesBlock>("Scenario Resources", 1));
            this.Fields.Add(new BlockField<OldUnusedStrucurePhysicsBlock>("Scenario Resources", 16));
            this.Fields.Add(new BlockField<HsUnitSeatBlock>(")hs Unit Seats", 65536));
            this.Fields.Add(new BlockField<ScenarioKillTriggerVolumesBlock>("Scenario Kill Triggers", 256));
            this.Fields.Add(new BlockField<SyntaxDatumBlock>("hs Syntax Datums*", 36864));
            this.Fields.Add(new BlockField<OrdersBlock>("Orders", 300));
            this.Fields.Add(new BlockField<TriggersBlock>("Triggers", 256));
            this.Fields.Add(new BlockField<StructureBspBackgroundSoundPaletteBlock>("Background Sound Palette", 64));
            this.Fields.Add(new BlockField<StructureBspSoundEnvironmentPaletteBlock>("Sound Environment Palette", 64));
            this.Fields.Add(new BlockField<StructureBspWeatherPaletteBlock>("Weather Palette", 32));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<ScenarioClusterDataBlock>("Scenario Cluster Data", 16));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new BlockField<ScenarioSpawnDataBlock>("Spawn Data", 1));
            this.Fields.Add(new TagReferenceField("Sound Effect Collection", 1936095275));
            this.Fields.Add(new BlockField<ScenarioCrateBlock>("Crates", 1024));
            this.Fields.Add(new BlockField<ScenarioCratePaletteBlock>("Crates Palette", 256));
            this.Fields.Add(new ExplanationField("Global Lighting Override", ""));
            this.Fields.Add(new TagReferenceField("Global Lighting", 1735156838));
            this.Fields.Add(new ExplanationField("WARNING", "Editing Fog palette data will not behave as expected with split scenarios."));
            this.Fields.Add(new BlockField<ScenarioAtmosphericFogPalette>("Atmospheric Fog Palette", 127));
            this.Fields.Add(new BlockField<ScenarioPlanarFogPalette>("Planar Fog Palette", 127));
            this.Fields.Add(new BlockField<FlockDefinitionBlock>("Flocks", 20));
            this.Fields.Add(new TagReferenceField("Subtitles", 1970170211));
            this.Fields.Add(new BlockField<DecoratorPlacementDefinitionBlock>("Decorators", 1));
            this.Fields.Add(new BlockField<ScenarioCreatureBlock>("Creatures", 128));
            this.Fields.Add(new BlockField<ScenarioCreaturePaletteBlock>("Creatures Palette", 256));
            this.Fields.Add(new BlockField<ScenarioDecoratorSetPaletteEntryBlock>("Decorators Palette", 32));
            this.Fields.Add(new BlockField<ScenarioBspSwitchTransitionVolumeBlock>(")BSP Transition Volumes", 256));
            this.Fields.Add(new BlockField<ScenarioStructureBspSphericalHarmonicLightingBlock>("Structure BSP Lighting", 16));
            this.Fields.Add(new BlockField<GScenarioEditorFolderBlock>(")Editor Folders", 32767));
            this.Fields.Add(new BlockField<ScenarioLevelDataBlock>("Level Data", 1));
            this.Fields.Add(new TagReferenceField("Territory Location Names", 1970170211));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new BlockField<AiScenarioMissionDialogueBlock>("Mission Dialogue", 1));
            this.Fields.Add(new TagReferenceField("Objectives", 1970170211));
            this.Fields.Add(new BlockField<ScenarioInterpolatorBlock>("Interpolators", 16));
            this.Fields.Add(new BlockField<HsReferencesBlock>("Shared References", 512));
            this.Fields.Add(new BlockField<ScenarioScreenEffectReferenceBlock>("Screen Effect References", 16));
            this.Fields.Add(new BlockField<ScenarioSimulationDefinitionTableBlock>("Simulation Definition Table", 512));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
