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
    /// Represents the generated decorator_cache_block_block tag block.
    /// </summary>
    public sealed class DecoratorCacheBlockBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorCacheBlockBlock"/> class.
        /// </summary>
        public DecoratorCacheBlockBlock()
        {
            this.Fields.Add(new StructField<GlobalGeometryBlockInfoStructBlock>("Geometry Block Info*"));
            this.Fields.Add(new BlockField<DecoratorCacheBlockDataBlock>("Cache Block Data*", 1));
        }
        /// <summary>
        /// Gets and returns the name of the decorator_cache_block_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "decorator_cache_block_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the decorator_cache_block_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "decorator_cache_block_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the decorator_cache_block_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4096;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the decorator_cache_block_block tag block.
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
