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
    /// Represents the generated error_report_vertices_block tag block.
    /// </summary>
    public sealed class ErrorReportVerticesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReportVerticesBlock"/> class.
        /// </summary>
        public ErrorReportVerticesBlock()
        {
            this.Fields.Add(new RealPoint3dField("Position*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealArgbColorField("Color*"));
            this.Fields.Add(new RealField("Screen Size*"));
        }
        /// <summary>
        /// Gets and returns the name of the error_report_vertices_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "error_report_vertices_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the error_report_vertices_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "error report vertex";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the error_report_vertices_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the error_report_vertices_block tag block.
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
