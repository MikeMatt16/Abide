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
    /// Represents the generated window_pane_reference_block tag block.
    /// </summary>
    public sealed class WindowPaneReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowPaneReferenceBlock"/> class.
        /// </summary>
        public WindowPaneReferenceBlock()
        {
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("animation index", "NONE", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"));
            this.Fields.Add(new ExplanationField("Button Definitions", "If the pane contains buttons, define them here"));
            this.Fields.Add(new BlockField<ButtonWidgetReferenceBlock>("buttons", 64));
            this.Fields.Add(new ExplanationField("List Definition", "If the pane contains a list, define it here"));
            this.Fields.Add(new BlockField<ListReferenceBlock>("list block", 1));
            this.Fields.Add(new ExplanationField("OBSOLETE Table View Definition", "If the pane contains a table-view, define it here"));
            this.Fields.Add(new BlockField<TableViewListReferenceBlock>("table view", 1));
            this.Fields.Add(new ExplanationField("Flavor Item Blocks", "Define additional flavor items here"));
            this.Fields.Add(new BlockField<TextBlockReferenceBlock>("text blocks", 64));
            this.Fields.Add(new BlockField<BitmapBlockReferenceBlock>("bitmap blocks", 64));
            this.Fields.Add(new BlockField<UiModelSceneReferenceBlock>("model scene blocks", 32));
            this.Fields.Add(new ExplanationField("UNUSED", "these are all OBSOLETE"));
            this.Fields.Add(new BlockField<STextValuePairBlocksBlockUNUSED>("text-value blocks", 100));
            this.Fields.Add(new BlockField<HudBlockReferenceBlock>("hud blocks", 64));
            this.Fields.Add(new BlockField<PlayerBlockReferenceBlock>("player blocks", 64));
        }
        /// <summary>
        /// Gets and returns the name of the window_pane_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "window_pane_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the window_pane_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "window_pane_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the window_pane_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the window_pane_reference_block tag block.
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