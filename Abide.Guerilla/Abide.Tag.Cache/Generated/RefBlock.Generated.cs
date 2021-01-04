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
    /// Represents the generated ref_block tag block.
    /// </summary>
    public sealed class RefBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefBlock"/> class.
        /// </summary>
        public RefBlock()
        {
            this.Fields.Add(new LongIntegerField("node ref or sector ref"));
        }
        /// <summary>
        /// Gets and returns the name of the ref_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ref_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ref_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ref_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ref_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ref_block tag block.
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
