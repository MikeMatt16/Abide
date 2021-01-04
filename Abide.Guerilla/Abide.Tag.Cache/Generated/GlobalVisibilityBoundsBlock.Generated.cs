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
    /// Represents the generated global_visibility_bounds_block tag block.
    /// </summary>
    public sealed class GlobalVisibilityBoundsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalVisibilityBoundsBlock"/> class.
        /// </summary>
        public GlobalVisibilityBoundsBlock()
        {
            this.Fields.Add(new RealField("Position x*"));
            this.Fields.Add(new RealField("Position y*"));
            this.Fields.Add(new RealField("Position z*"));
            this.Fields.Add(new RealField("Radius*"));
            this.Fields.Add(new CharIntegerField("Node 0*"));
            this.Fields.Add(new PadField("", 3));
        }
        /// <summary>
        /// Gets and returns the name of the global_visibility_bounds_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_visibility_bounds_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_visibility_bounds_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "visibility bounds";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_visibility_bounds_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32768;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_visibility_bounds_block tag block.
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
