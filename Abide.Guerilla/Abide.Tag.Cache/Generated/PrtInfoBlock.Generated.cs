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
    /// Represents the generated prt_info_block tag block.
    /// </summary>
    public sealed class PrtInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrtInfoBlock"/> class.
        /// </summary>
        public PrtInfoBlock()
        {
            this.Fields.Add(new ShortIntegerField("SH Order*"));
            this.Fields.Add(new ShortIntegerField("num of clusters*"));
            this.Fields.Add(new ShortIntegerField("pca vectors per cluster*"));
            this.Fields.Add(new ShortIntegerField("number of rays*"));
            this.Fields.Add(new ShortIntegerField("number of bounces*"));
            this.Fields.Add(new ShortIntegerField("mat index for sbsfc scattering*"));
            this.Fields.Add(new RealField("length scale*"));
            this.Fields.Add(new ShortIntegerField("number of lods in model*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<PrtLodInfoBlock>("lod info*", 6));
            this.Fields.Add(new BlockField<PrtClusterBasisBlock>("cluster basis*", 34560));
            this.Fields.Add(new BlockField<PrtRawPcaDataBlock>("raw_pca_data*", 150405120));
            this.Fields.Add(new BlockField<PrtVertexBuffersBlock>("vertex buffers*", 255));
            this.Fields.Add(new StructField<GlobalGeometryBlockInfoStructBlock>("geometry block info*"));
        }
        /// <summary>
        /// Gets and returns the name of the prt_info_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "prt_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the prt_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "prt_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the prt_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the prt_info_block tag block.
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
