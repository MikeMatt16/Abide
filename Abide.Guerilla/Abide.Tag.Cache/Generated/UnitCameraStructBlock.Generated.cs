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
    /// Represents the generated unit_camera_struct_block tag block.
    /// </summary>
    public sealed class UnitCameraStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitCameraStructBlock"/> class.
        /// </summary>
        public UnitCameraStructBlock()
        {
            this.Fields.Add(new OldStringIdField("camera marker name"));
            this.Fields.Add(new OldStringIdField("camera submerged marker name"));
            this.Fields.Add(new AngleField("pitch auto-level"));
            this.Fields.Add(new AngleBoundsField("pitch range"));
            this.Fields.Add(new BlockField<UnitCameraTrackBlock>("camera tracks", 2));
        }
        /// <summary>
        /// Gets and returns the name of the unit_camera_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "unit_camera_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_camera_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_camera_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_camera_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_camera_struct_block tag block.
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
