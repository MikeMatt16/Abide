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
    /// Represents the generated decorator_cache_block_data_block tag block.
    /// </summary>
    public sealed class DecoratorCacheBlockDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorCacheBlockDataBlock"/> class.
        /// </summary>
        public DecoratorCacheBlockDataBlock()
        {
            this.Fields.Add(new BlockField<DecoratorPlacementBlock>("Placements*", 32768));
            this.Fields.Add(new BlockField<DecalVerticesBlock>("Decal Vertices*", 65536));
            this.Fields.Add(new BlockField<IndicesBlock>("Decal Indices*", 65536));
            this.Fields.Add(new VertexBufferField("decal vertex buffer*"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new BlockField<SpriteVerticesBlock>("Sprite Vertices*", 65536));
            this.Fields.Add(new BlockField<IndicesBlock>("Sprite Indices*", 65536));
            this.Fields.Add(new VertexBufferField("sprite vertex buffer*"));
            this.Fields.Add(new PadField("", 16));
        }
        /// <summary>
        /// Gets and returns the name of the decorator_cache_block_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "decorator_cache_block_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the decorator_cache_block_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "decorator_cache_block_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the decorator_cache_block_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the decorator_cache_block_data_block tag block.
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
