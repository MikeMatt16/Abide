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
    /// Represents the generated bsp3d_nodes_block tag block.
    /// </summary>
    public sealed class Bsp3dNodesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bsp3dNodesBlock"/> class.
        /// </summary>
        public Bsp3dNodesBlock()
        {
            this.Fields.Add(new SkipField("", 8));
        }
        /// <summary>
        /// Gets and returns the name of the bsp3d_nodes_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bsp3d_nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bsp3d_nodes_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bsp3d_nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bsp3d_nodes_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bsp3d_nodes_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 8;
            }
        }
    }
}
