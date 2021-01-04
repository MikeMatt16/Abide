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
    /// Represents the generated response_block tag block.
    /// </summary>
    public sealed class ResponseBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBlock"/> class.
        /// </summary>
        public ResponseBlock()
        {
            this.Fields.Add(new StringIdField("vocalization name"));
            this.Fields.Add(new WordFlagsField("flags", "nonexclusive", "trigger response"));
            this.Fields.Add(new ShortIntegerField("vocalization index (post process)*"));
            this.Fields.Add(new EnumField("response type", "friend", "enemy", "listener", "joint", "peer"));
            this.Fields.Add(new ShortIntegerField("dialogue index (import)*"));
        }
        /// <summary>
        /// Gets and returns the name of the response_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "response_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the response_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "response_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the response_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the response_block tag block.
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