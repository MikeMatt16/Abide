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
    /// Represents the generated sound_promotion_rule_block tag block.
    /// </summary>
    public sealed class SoundPromotionRuleBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundPromotionRuleBlock"/> class.
        /// </summary>
        public SoundPromotionRuleBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("pitch range^"));
            this.Fields.Add(new ShortIntegerField("maximum playing count"));
            this.Fields.Add(new RealField("suppression time:seconds#time from when first permutation plays to when another s" +
                        "ound from an equal or lower promotion can play"));
            this.Fields.Add(new PadField("", 8));
        }
        /// <summary>
        /// Gets and returns the name of the sound_promotion_rule_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_promotion_rule_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_promotion_rule_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_promotion_rule_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_promotion_rule_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 9;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_promotion_rule_block tag block.
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
