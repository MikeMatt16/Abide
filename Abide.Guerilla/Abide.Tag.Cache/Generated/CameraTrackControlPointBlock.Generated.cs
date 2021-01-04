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
    /// Represents the generated camera_track_control_point_block tag block.
    /// </summary>
    public sealed class CameraTrackControlPointBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraTrackControlPointBlock"/> class.
        /// </summary>
        public CameraTrackControlPointBlock()
        {
            this.Fields.Add(new RealVector3dField("position"));
            this.Fields.Add(new QuaternionField("orientation"));
        }
        /// <summary>
        /// Gets and returns the name of the camera_track_control_point_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "camera_track_control_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the camera_track_control_point_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "camera_track_control_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the camera_track_control_point_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the camera_track_control_point_block tag block.
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
