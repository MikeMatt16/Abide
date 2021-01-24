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
    /// Represents the generated device_machine_block tag block.
    /// </summary>
    public sealed class DeviceMachineBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMachineBlock"/> class.
        /// </summary>
        public DeviceMachineBlock()
        {
            this.Fields.Add(new ExplanationField("$$$ MACHINE $$$", ""));
            this.Fields.Add(new EnumField("type", "door", "platform", "gear"));
            this.Fields.Add(new WordFlagsField("flags", "pathfinding obstacle", "...but not when open", "elevator#lighting based on what\'s around, rather than what\'s below"));
            this.Fields.Add(new RealField("door open time:seconds"));
            this.Fields.Add(new RealFractionBoundsField("door occlusion bounds#maps position [0,1] to occlusion"));
            this.Fields.Add(new EnumField("collision response", "pause until crushed", "reverse directions"));
            this.Fields.Add(new ShortIntegerField("elevator node"));
            this.Fields.Add(new EnumField("pathfinding policy", "discs", "sectors", "cut_out", "none"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the device_machine_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "device_machine_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the device_machine_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "device_machine";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the device_machine_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the device_machine_block tag block.
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
