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
    /// Represents the generated structure_bsp_environment_object_palette_block tag block.
    /// </summary>
    public sealed class StructureBspEnvironmentObjectPaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspEnvironmentObjectPaletteBlock"/> class.
        /// </summary>
        public StructureBspEnvironmentObjectPaletteBlock()
        {
            this.Fields.Add(new TagReferenceField("Definition", 1935893870));
            this.Fields.Add(new TagReferenceField("Model", 1836016741));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_environment_object_palette_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_bsp_environment_object_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_environment_object_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_environment_object_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_environment_object_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_environment_object_palette_block tag block.
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
