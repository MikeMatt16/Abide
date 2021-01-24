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
    /// Represents the generated cloth_indices_block tag block.
    /// </summary>
    public sealed class ClothIndicesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClothIndicesBlock"/> class.
        /// </summary>
        public ClothIndicesBlock()
        {
            this.Fields.Add(new ShortIntegerField("index*"));
        }
        /// <summary>
        /// Gets and returns the name of the cloth_indices_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "cloth_indices_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cloth_indices_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cloth_indices_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cloth_indices_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 768;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cloth_indices_block tag block.
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
