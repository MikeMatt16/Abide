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
    /// Represents the generated table_view_list_row_reference_block tag block.
    /// </summary>
    public sealed class TableViewListRowReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewListRowReferenceBlock"/> class.
        /// </summary>
        public TableViewListRowReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "unused"));
            this.Fields.Add(new ShortIntegerField("row height"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<TableViewListItemReferenceBlock>("row cells", 8));
        }
        /// <summary>
        /// Gets and returns the name of the table_view_list_row_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "table_view_list_row_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the table_view_list_row_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "table_view_list_row_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the table_view_list_row_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the table_view_list_row_reference_block tag block.
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
