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
    /// Represents the generated breakable_surface_key_table_block tag block.
    /// </summary>
    public sealed class BreakableSurfaceKeyTableBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakableSurfaceKeyTableBlock"/> class.
        /// </summary>
        public BreakableSurfaceKeyTableBlock()
        {
            this.Fields.Add(new ShortIntegerField("*"));
            this.Fields.Add(new ShortIntegerField("*"));
            this.Fields.Add(new LongIntegerField("*"));
            this.Fields.Add(new RealField("*"));
            this.Fields.Add(new RealField("*"));
            this.Fields.Add(new RealField("*"));
            this.Fields.Add(new RealField("*"));
            this.Fields.Add(new RealField("*"));
            this.Fields.Add(new RealField("*"));
        }
        /// <summary>
        /// Gets and returns the name of the breakable_surface_key_table_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "breakable_surface_key_table_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the breakable_surface_key_table_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "breakable_surface_key_table_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the breakable_surface_key_table_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8192;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the breakable_surface_key_table_block tag block.
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