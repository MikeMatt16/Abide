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
    /// Represents the generated structure_device_portal_association_block tag block.
    /// </summary>
    public sealed class StructureDevicePortalAssociationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureDevicePortalAssociationBlock"/> class.
        /// </summary>
        public StructureDevicePortalAssociationBlock()
        {
            this.Fields.Add(new StructField<ScenarioObjectIdStructBlock>("device id"));
            this.Fields.Add(new ShortIntegerField("first game portal index"));
            this.Fields.Add(new ShortIntegerField("game portal count"));
        }
        /// <summary>
        /// Gets and returns the name of the structure_device_portal_association_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_device_portal_association_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_device_portal_association_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_device_portal_association_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_device_portal_association_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_device_portal_association_block tag block.
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
