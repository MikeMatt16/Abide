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
    /// Represents the generated structure_portal_device_mapping_block tag block.
    /// </summary>
    public sealed class StructurePortalDeviceMappingBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructurePortalDeviceMappingBlock"/> class.
        /// </summary>
        public StructurePortalDeviceMappingBlock()
        {
            this.Fields.Add(new BlockField<StructureDevicePortalAssociationBlock>("device portal associations", 128));
            this.Fields.Add(new BlockField<GamePortalToPortalMappingBlock>("game portal to portal map", 128));
        }
        /// <summary>
        /// Gets and returns the name of the structure_portal_device_mapping_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_portal_device_mapping_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_portal_device_mapping_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_portal_device_mapping_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_portal_device_mapping_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_portal_device_mapping_block tag block.
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
