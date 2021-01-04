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
    /// Represents the generated scenario_biped_palette_block tag block.
    /// </summary>
    public sealed class ScenarioBipedPaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioBipedPaletteBlock"/> class.
        /// </summary>
        public ScenarioBipedPaletteBlock()
        {
            this.Fields.Add(new TagReferenceField("Name^", 1651077220));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_biped_palette_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_biped_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_biped_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_biped_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_biped_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_biped_palette_block tag block.
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
