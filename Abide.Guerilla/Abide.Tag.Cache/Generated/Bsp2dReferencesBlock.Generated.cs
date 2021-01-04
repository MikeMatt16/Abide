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
    /// Represents the generated bsp2d_references_block tag block.
    /// </summary>
    public sealed class Bsp2dReferencesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bsp2dReferencesBlock"/> class.
        /// </summary>
        public Bsp2dReferencesBlock()
        {
            this.Fields.Add(new ShortIntegerField("Plane*"));
            this.Fields.Add(new ShortIntegerField("BSP 2D Node*"));
        }
        /// <summary>
        /// Gets and returns the name of the bsp2d_references_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bsp2d_references_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bsp2d_references_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bsp2d_references_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bsp2d_references_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bsp2d_references_block tag block.
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
