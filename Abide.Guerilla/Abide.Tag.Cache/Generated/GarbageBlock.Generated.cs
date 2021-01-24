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
    /// Represents the generated garbage_block tag block.
    /// </summary>
    public sealed class GarbageBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GarbageBlock"/> class.
        /// </summary>
        public GarbageBlock()
        {
            this.Fields.Add(new PadField("", 168));
        }
        /// <summary>
        /// Gets and returns the name of the garbage_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "garbage_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the garbage_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "garbage";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the garbage_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the garbage_block tag block.
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
