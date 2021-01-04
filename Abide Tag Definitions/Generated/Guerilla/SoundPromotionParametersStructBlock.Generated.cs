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
    /// Represents the generated sound_promotion_parameters_struct_block tag block.
    /// </summary>
    public sealed class SoundPromotionParametersStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundPromotionParametersStructBlock"/> class.
        /// </summary>
        public SoundPromotionParametersStructBlock()
        {
            this.Fields.Add(new BlockField<SoundPromotionRuleBlock>("promotion rules", 9));
            this.Fields.Add(new BlockField<SoundPromotionRuntimeTimerBlock>("", 9));
            this.Fields.Add(new PadField("", 12));
        }
        /// <summary>
        /// Gets and returns the name of the sound_promotion_parameters_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_promotion_parameters_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_promotion_parameters_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_promotion_parameters_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_promotion_parameters_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_promotion_parameters_struct_block tag block.
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
