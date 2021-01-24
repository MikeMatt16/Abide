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
    /// Represents the generated involuntary_data_block tag block.
    /// </summary>
    public sealed class InvoluntaryDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoluntaryDataBlock"/> class.
        /// </summary>
        public InvoluntaryDataBlock()
        {
            this.Fields.Add(new ShortIntegerField("involuntary vocalization index*"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the involuntary_data_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "involuntary_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the involuntary_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "involuntary_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the involuntary_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the involuntary_data_block tag block.
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
