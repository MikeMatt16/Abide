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
    /// Represents the generated scenario_device_struct_block tag block.
    /// </summary>
    public sealed class ScenarioDeviceStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioDeviceStructBlock"/> class.
        /// </summary>
        public ScenarioDeviceStructBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("Power Group"));
            this.Fields.Add(new ShortBlockIndexField("Position Group"));
            this.Fields.Add(new LongFlagsField("Flags", "Initially Open (1.0)", "Initially Off (0.0)", "Can change only once.", "Position Reversed", "Not Usable from Any Side"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_device_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_device_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_device_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_device_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_device_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_device_struct_block tag block.
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
