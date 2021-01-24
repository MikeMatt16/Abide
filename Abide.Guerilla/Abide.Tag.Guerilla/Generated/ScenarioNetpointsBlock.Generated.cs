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
    /// Represents the generated scenario_netpoints_block tag block.
    /// </summary>
    public sealed class ScenarioNetpointsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioNetpointsBlock"/> class.
        /// </summary>
        public ScenarioNetpointsBlock()
        {
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new AngleField("Facing:Degrees"));
            this.Fields.Add(new EnumField("Type", "CTF Flag Spawn", "CTF Flag Return", "Assault Bomb Spawn", "Assault Bomb Return", "Oddball Spawn", "unused", "Race Checkpoint", "Teleporter (src)", "Teleporter (dest)", "Headhunter Bin", "Territories Flag", "King Hill 0", "King Hill 1", "King Hill 2", "King Hill 3", "King Hill 4", "King Hill 5", "King Hill 6", "King Hill 7"));
            this.Fields.Add(new EnumField("Team Designator", "Red (Alpha)", "Blue (Bravo)", "Yellow (Charlie)", "Green (Delta)", "Purple (Echo)", "Orange (Foxtrot)", "Brown (Golf)", "Pink (Hotel)", "NEUTRAL"));
            this.Fields.Add(new ShortIntegerField("Identifier"));
            this.Fields.Add(new WordFlagsField("Flags", "Multiple Flag/Bomb", "Single Flag/Bomb", "Neutral Flag/Bomb"));
            this.Fields.Add(new StringIdField(""));
            this.Fields.Add(new StringIdField(""));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_netpoints_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_netpoints_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_netpoints_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_netpoints_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_netpoints_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 200;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_netpoints_block tag block.
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
