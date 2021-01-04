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
    /// Represents the generated occluder_to_machine_door_mapping tag block.
    /// </summary>
    public sealed class OccluderToMachineDoorMapping : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccluderToMachineDoorMapping"/> class.
        /// </summary>
        public OccluderToMachineDoorMapping()
        {
            this.Fields.Add(new CharIntegerField("machine door index"));
        }
        /// <summary>
        /// Gets and returns the name of the occluder_to_machine_door_mapping tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "occluder_to_machine_door_mapping";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the occluder_to_machine_door_mapping tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "occluder_to_machine_door_mapping";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the occluder_to_machine_door_mapping tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the occluder_to_machine_door_mapping tag block.
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
