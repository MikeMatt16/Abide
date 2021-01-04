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
    /// Represents the generated structure_bsp_breakable_surface_block tag block.
    /// </summary>
    public sealed class StructureBspBreakableSurfaceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspBreakableSurfaceBlock"/> class.
        /// </summary>
        public StructureBspBreakableSurfaceBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("Instanced Geometry Instance*"));
            this.Fields.Add(new ShortIntegerField("Breakable Surface Index*"));
            this.Fields.Add(new RealPoint3dField("Centroid*"));
            this.Fields.Add(new RealField("Radius*"));
            this.Fields.Add(new LongIntegerField("Collision Surface Index*"));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_breakable_surface_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_bsp_breakable_surface_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_breakable_surface_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_breakable_surface_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_breakable_surface_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8448;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_breakable_surface_block tag block.
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
