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
    /// Represents the generated structure_lightmap_palette_color_block tag block.
    /// </summary>
    public sealed class StructureLightmapPaletteColorBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureLightmapPaletteColorBlock"/> class.
        /// </summary>
        public StructureLightmapPaletteColorBlock()
        {
            this.Fields.Add(new LongIntegerField("FIRST palette color*"));
            this.Fields.Add(new SkipField("", 1020));
        }
        /// <summary>
        /// Gets and returns the name of the structure_lightmap_palette_color_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_lightmap_palette_color_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_lightmap_palette_color_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_lightmap_palette_color_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_lightmap_palette_color_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_lightmap_palette_color_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 64;
            }
        }
    }
}
