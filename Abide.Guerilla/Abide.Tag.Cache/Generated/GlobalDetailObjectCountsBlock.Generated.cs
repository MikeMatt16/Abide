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
    /// Represents the generated global_detail_object_counts_block tag block.
    /// </summary>
    public sealed class GlobalDetailObjectCountsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalDetailObjectCountsBlock"/> class.
        /// </summary>
        public GlobalDetailObjectCountsBlock()
        {
            this.Fields.Add(new ShortIntegerField("*"));
        }
        /// <summary>
        /// Gets and returns the name of the global_detail_object_counts_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_detail_object_counts_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_detail_object_counts_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_detail_object_counts_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_detail_object_counts_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8388608;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_detail_object_counts_block tag block.
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