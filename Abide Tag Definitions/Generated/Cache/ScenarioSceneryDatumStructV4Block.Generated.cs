//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated scenario_scenery_datum_struct_v4_block tag block.
    /// </summary>
    public sealed class ScenarioSceneryDatumStructV4Block : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioSceneryDatumStructV4Block"/> class.
        /// </summary>
        public ScenarioSceneryDatumStructV4Block()
        {
            this.Fields.Add(new EnumField("Pathfinding Policy", "Tag Default", "Pathfinding DYNAMIC", "Pathfinding CUT-OUT", "Pathfinding STATIC", "Pathfinding NONE"));
            this.Fields.Add(new EnumField("Lightmapping Policy", "Tag Default", "Dynamic", "Per-Vertex"));
            this.Fields.Add(new BlockField<PathfindingObjectIndexListBlock>("Pathfinding References*", 16));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new WordFlagsField("Valid Multiplayer Games", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Juggernaut", "Territories", "Assault"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_scenery_datum_struct_v4_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_scenery_datum_struct_v4_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_scenery_datum_struct_v4_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_scenery_datum_struct_v4";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_scenery_datum_struct_v4_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_scenery_datum_struct_v4_block tag block.
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
