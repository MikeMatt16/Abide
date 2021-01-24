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
    /// Represents the generated visibility_struct_block tag block.
    /// </summary>
    public sealed class VisibilityStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisibilityStructBlock"/> class.
        /// </summary>
        public VisibilityStructBlock()
        {
            this.Fields.Add(new ShortIntegerField("Projection Count*"));
            this.Fields.Add(new ShortIntegerField("Cluster Count*"));
            this.Fields.Add(new ShortIntegerField("Volume Count*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new DataField("Projections*", 1, 4));
            this.Fields.Add(new DataField("Visibility Clusters*", 1, 4));
            this.Fields.Add(new DataField("Cluster Remap Table*", 1, 4));
            this.Fields.Add(new DataField("Visibility Volumes*", 1, 4));
        }
        /// <summary>
        /// Gets and returns the name of the visibility_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "visibility_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the visibility_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "visibility_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the visibility_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the visibility_struct_block tag block.
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
