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
    /// Represents the generated render_model_invalid_section_pairs_block tag block.
    /// </summary>
    public sealed class RenderModelInvalidSectionPairsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderModelInvalidSectionPairsBlock"/> class.
        /// </summary>
        public RenderModelInvalidSectionPairsBlock()
        {
            this.Fields.Add(new LongIntegerField("bits*"));
        }
        /// <summary>
        /// Gets and returns the name of the render_model_invalid_section_pairs_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "render_model_invalid_section_pairs_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_model_invalid_section_pairs_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bitvector";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_model_invalid_section_pairs_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1013;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_model_invalid_section_pairs_block tag block.
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
