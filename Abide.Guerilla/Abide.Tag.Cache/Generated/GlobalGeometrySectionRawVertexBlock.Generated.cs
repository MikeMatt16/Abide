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
    /// Represents the generated global_geometry_section_raw_vertex_block tag block.
    /// </summary>
    public sealed class GlobalGeometrySectionRawVertexBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometrySectionRawVertexBlock"/> class.
        /// </summary>
        public GlobalGeometrySectionRawVertexBlock()
        {
            this.Fields.Add(new RealPoint3dField("Position*"));
            this.Fields.Add(new LongIntegerField("Node Index (OLD)*"));
            this.Fields.Add(new LongIntegerField("Node Index (OLD)*"));
            this.Fields.Add(new LongIntegerField("Node Index (OLD)*"));
            this.Fields.Add(new LongIntegerField("Node Index (OLD)*"));
            this.Fields.Add(new RealField("node_weight*"));
            this.Fields.Add(new RealField("node_weight*"));
            this.Fields.Add(new RealField("node_weight*"));
            this.Fields.Add(new RealField("node_weight*"));
            this.Fields.Add(new LongIntegerField("Node Index (NEW)*"));
            this.Fields.Add(new LongIntegerField("Node Index (NEW)*"));
            this.Fields.Add(new LongIntegerField("Node Index (NEW)*"));
            this.Fields.Add(new LongIntegerField("Node Index (NEW)*"));
            this.Fields.Add(new LongIntegerField("Use New Node Indices*"));
            this.Fields.Add(new LongIntegerField("Adjusted Compound Node Index*"));
            this.Fields.Add(new RealPoint2dField("texcoord*"));
            this.Fields.Add(new RealVector3dField("Normal*"));
            this.Fields.Add(new RealVector3dField("Binormal*"));
            this.Fields.Add(new RealVector3dField("Tangent*"));
            this.Fields.Add(new RealVector3dField("Anisotropic Binormal*"));
            this.Fields.Add(new RealPoint2dField("Secondary texcoord*"));
            this.Fields.Add(new RealRgbColorField("Primary Lightmap Color"));
            this.Fields.Add(new RealPoint2dField("Primary Lightmap texcoord"));
            this.Fields.Add(new RealVector3dField("Primary Lightmap Incident Direction"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 12));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_section_raw_vertex_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_geometry_section_raw_vertex_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_section_raw_vertex_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vertex";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_section_raw_vertex_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32767;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_section_raw_vertex_block tag block.
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
