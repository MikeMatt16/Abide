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
    /// Represents the generated structure_bsp_sound_environment_palette_block tag block.
    /// </summary>
    public sealed class StructureBspSoundEnvironmentPaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspSoundEnvironmentPaletteBlock"/> class.
        /// </summary>
        public StructureBspSoundEnvironmentPaletteBlock()
        {
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new TagReferenceField("Sound Environment", 1936614501));
            this.Fields.Add(new RealField("Cutoff Distance"));
            this.Fields.Add(new RealField("Interpolation Speed:1/sec"));
            this.Fields.Add(new PadField("", 24));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_sound_environment_palette_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_bsp_sound_environment_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_sound_environment_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_sound_environment_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_sound_environment_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_sound_environment_palette_block tag block.
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