//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated render_model_section_data_block tag block.
    /// </summary>
    public sealed class RenderModelSectionDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderModelSectionDataBlock"/> class.
        /// </summary>
        public RenderModelSectionDataBlock()
        {
            this.Fields.Add(new StructField<GlobalGeometrySectionStructBlock>("section*"));
            this.Fields.Add(new StructField<GlobalGeometryPointDataStructBlock>("point data*"));
            this.Fields.Add(new BlockField<RenderModelNodeMapBlock>("node map*", 40));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the render_model_section_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "render_model_section_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_model_section_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "render_model_section_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_model_section_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_model_section_data_block tag block.
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
