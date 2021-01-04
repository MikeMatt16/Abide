//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated scenario_scenery_resource_block tag block.
    /// </summary>
    public sealed class ScenarioSceneryResourceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioSceneryResourceBlock"/> class.
        /// </summary>
        public ScenarioSceneryResourceBlock()
        {
            this.Fields.Add(new BlockField<ScenarioObjectNamesBlock>("Names", 640));
            this.Fields.Add(new BlockField<DontUseMeScenarioEnvironmentObjectBlock>("*", 4096));
            this.Fields.Add(new BlockField<ScenarioStructureBspReferenceBlock>("Structure References", 16));
            this.Fields.Add(new BlockField<ScenarioSceneryPaletteBlock>("Palette", 256));
            this.Fields.Add(new BlockField<ScenarioSceneryBlock>("Objects", 2000));
            this.Fields.Add(new LongIntegerField("Next Scenery Object ID Salt*"));
            this.Fields.Add(new BlockField<ScenarioCratePaletteBlock>("Palette", 256));
            this.Fields.Add(new BlockField<ScenarioCrateBlock>("Objects", 1024));
            this.Fields.Add(new LongIntegerField("Next Block Object ID Salt*"));
            this.Fields.Add(new BlockField<GScenarioEditorFolderBlock>("Editor Folders*", 32767));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_scenery_resource_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_scenery_resource_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_scenery_resource_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_scenery_resource";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_scenery_resource_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_scenery_resource_block tag block.
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
