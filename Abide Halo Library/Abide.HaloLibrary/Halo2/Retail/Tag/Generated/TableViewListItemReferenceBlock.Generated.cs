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
    /// Represents the generated table_view_list_item_reference_block tag block.
    /// </summary>
    public sealed class TableViewListItemReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewListItemReferenceBlock"/> class.
        /// </summary>
        public TableViewListItemReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("text flags", "left justify text", "right justify text", "pulsating text", "callout text", "small (31 char) buffer"));
            this.Fields.Add(new ShortIntegerField("cell width"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new Point2dField("bitmap top-left:if there is a bitmap"));
            this.Fields.Add(new TagReferenceField("bitmap tag", 1651078253));
            this.Fields.Add(new StringIdField("string id"));
            this.Fields.Add(new ShortIntegerField("render depth bias"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the table_view_list_item_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "table_view_list_item_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the table_view_list_item_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "table_view_list_item_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the table_view_list_item_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the table_view_list_item_reference_block tag block.
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
