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
    /// Represents the generated global_geometry_section_strip_index_block tag block.
    /// </summary>
    public sealed class GlobalGeometrySectionStripIndexBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometrySectionStripIndexBlock"/> class.
        /// </summary>
        public GlobalGeometrySectionStripIndexBlock()
        {
            this.Fields.Add(new ShortIntegerField("Index*"));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_section_strip_index_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_geometry_section_strip_index_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_section_strip_index_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "index";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_section_strip_index_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65535;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_section_strip_index_block tag block.
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
