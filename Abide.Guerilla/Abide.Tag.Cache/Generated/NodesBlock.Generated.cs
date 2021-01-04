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
    /// Represents the generated nodes_block tag block.
    /// </summary>
    public sealed class NodesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodesBlock"/> class.
        /// </summary>
        public NodesBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new WordFlagsField("flags", "does not animate"));
            this.Fields.Add(new ShortBlockIndexField("parent*"));
            this.Fields.Add(new ShortBlockIndexField("sibling*"));
            this.Fields.Add(new ShortBlockIndexField("child*"));
        }
        /// <summary>
        /// Gets and returns the name of the nodes_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the nodes_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the nodes_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the nodes_block tag block.
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
