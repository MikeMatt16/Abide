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
    /// Represents the generated device_control (ctrl) tag group.
    /// </summary>
    public class DeviceControl : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceControl"/> class.
        /// </summary>
        public DeviceControl()
        {
            // Add parent object tag block to list.
            this.TagBlocks.Add(new ObjectBlock());
            // Add parent device tag block to list.
            this.TagBlocks.Add(new DeviceBlock());
            // Add tag block to list.
            this.TagBlocks.Add(new DeviceControlBlock());
        }
        /// <summary>
        /// Gets and returns the name of the device_control tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "device_control";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the device_control tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "ctrl";
            }
        }
    }
}
