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
    /// Represents the generated sound_permutation_dialogue_info_block tag block.
    /// </summary>
    public sealed class SoundPermutationDialogueInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundPermutationDialogueInfoBlock"/> class.
        /// </summary>
        public SoundPermutationDialogueInfoBlock()
        {
            this.Fields.Add(new LongIntegerField("mouth data offset"));
            this.Fields.Add(new LongIntegerField("mouth data length"));
            this.Fields.Add(new LongIntegerField("lipsync data offset"));
            this.Fields.Add(new LongIntegerField("lipsync data length"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_permutation_dialogue_info_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_permutation_dialogue_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_permutation_dialogue_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_permutation_dialogue_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_permutation_dialogue_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 288;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_permutation_dialogue_info_block tag block.
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
