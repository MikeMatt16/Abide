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
    /// Represents the generated ui_campaign_block tag block.
    /// </summary>
    public sealed class UiCampaignBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiCampaignBlock"/> class.
        /// </summary>
        public UiCampaignBlock()
        {
            this.Fields.Add(new LongIntegerField("Campaign ID"));
            this.Fields.Add(new SkipField("", 576));
            this.Fields.Add(new SkipField("", 2304));
        }
        /// <summary>
        /// Gets and returns the name of the ui_campaign_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "ui_campaign_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ui_campaign_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ui_campaign_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ui_campaign_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ui_campaign_block tag block.
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
