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
    /// Represents the generated button_widget_reference_block tag block.
    /// </summary>
    public sealed class ButtonWidgetReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonWidgetReferenceBlock"/> class.
        /// </summary>
        public ButtonWidgetReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("text flags", "left justify text", "right justify text", "pulsating text", "callout text", "small (31 char) buffer"));
            this.Fields.Add(new EnumField("animation index", "NONE", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"));
            this.Fields.Add(new ShortIntegerField("intro animation delay milliseconds"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("custom font", "terminal", "body text", "title", "super large font", "large body text", "split screen hud message", "full screen hud message", "english body text", "HUD number text", "subtitle font", "main menu font", "text chat font"));
            this.Fields.Add(new RealArgbColorField("text color"));
            this.Fields.Add(new Rectangle2dField("bounds"));
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
            this.Fields.Add(new Point2dField("bitmap offset#from top-left"));
            this.Fields.Add(new StringIdField("string id"));
            this.Fields.Add(new ShortIntegerField("render depth bias"));
            this.Fields.Add(new ShortIntegerField("mouse region top offset"));
            this.Fields.Add(new LongFlagsField("button flags", "DOESN\'T tab vertically", "DOESN\'T tab horizontally"));
        }
        /// <summary>
        /// Gets and returns the name of the button_widget_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "button_widget_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the button_widget_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "button_widget_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the button_widget_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the button_widget_reference_block tag block.
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
