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
    /// Represents the generated sky_cubemap_block tag block.
    /// </summary>
    public sealed class SkyCubemapBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkyCubemapBlock"/> class.
        /// </summary>
        public SkyCubemapBlock()
        {
            this.Fields.Add(new TagReferenceField("Cube Map Reference", 1651078253));
            this.Fields.Add(new RealField("Power Scale#0 Defaults to 1."));
        }
        /// <summary>
        /// Gets and returns the name of the sky_cubemap_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sky_cubemap_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sky_cubemap_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sky_cubemap_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sky_cubemap_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sky_cubemap_block tag block.
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
