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
    /// Represents the generated scenario_netgame_equipment_orientation_struct_block tag block.
    /// </summary>
    public sealed class ScenarioNetgameEquipmentOrientationStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioNetgameEquipmentOrientationStructBlock"/> class.
        /// </summary>
        public ScenarioNetgameEquipmentOrientationStructBlock()
        {
            this.Fields.Add(new EulerAngles3dField("Orientation"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_netgame_equipment_orientation_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_netgame_equipment_orientation_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_netgame_equipment_orientation_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_netgame_equipment_orientation_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_netgame_equipment_orientation_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_netgame_equipment_orientation_struct_block tag block.
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
