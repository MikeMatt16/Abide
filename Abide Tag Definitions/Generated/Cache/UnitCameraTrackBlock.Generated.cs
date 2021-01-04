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
    /// Represents the generated unit_camera_track_block tag block.
    /// </summary>
    public sealed class UnitCameraTrackBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitCameraTrackBlock"/> class.
        /// </summary>
        public UnitCameraTrackBlock()
        {
            this.Fields.Add(new TagReferenceField("track", 1953653099));
        }
        /// <summary>
        /// Gets and returns the name of the unit_camera_track_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_camera_track_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_camera_track_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_camera_track_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_camera_track_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_camera_track_block tag block.
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
