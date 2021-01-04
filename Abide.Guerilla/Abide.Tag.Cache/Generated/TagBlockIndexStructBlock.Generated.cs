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
    /// Represents the generated tag_block_index_struct_block tag block.
    /// </summary>
    public sealed class TagBlockIndexStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagBlockIndexStructBlock"/> class.
        /// </summary>
        public TagBlockIndexStructBlock()
        {
            this.Fields.Add(new CharIntegerField("index"));
            this.Fields.Add(new CharIntegerField("Length"));
        }
        /// <summary>
        /// Gets and returns the name of the tag_block_index_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "tag_block_index_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the tag_block_index_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "tag_block_index_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the tag_block_index_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the tag_block_index_struct_block tag block.
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
