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
    /// Represents the generated point_to_path_curve_block tag block.
    /// </summary>
    public sealed class PointToPathCurveBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointToPathCurveBlock"/> class.
        /// </summary>
        public PointToPathCurveBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new ShortBlockIndexField("node index*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<PointToPathCurvePointBlock>("points*", 1024));
        }
        /// <summary>
        /// Gets and returns the name of the point_to_path_curve_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "point_to_path_curve_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the point_to_path_curve_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "point_to_path_curve_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the point_to_path_curve_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the point_to_path_curve_block tag block.
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
