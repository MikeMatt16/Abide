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
    /// Represents the generated scenario_machine_struct_v3_block tag block.
    /// </summary>
    public sealed class ScenarioMachineStructV3Block : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioMachineStructV3Block"/> class.
        /// </summary>
        public ScenarioMachineStructV3Block()
        {
            this.Fields.Add(new LongFlagsField("Flags", "Does Not Operate Automatically", "One-Sided", "Never Appears Locked", "Opened by Melee Attack", "One-Sided for Player", "Does Not Close Automatically"));
            this.Fields.Add(new BlockField<PathfindingObjectIndexListBlock>("Pathfinding References*", 16));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_machine_struct_v3_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_machine_struct_v3_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_machine_struct_v3_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_machine_struct_v3";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_machine_struct_v3_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_machine_struct_v3_block tag block.
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
