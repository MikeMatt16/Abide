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
    /// Represents the generated sound_extra_info_block tag block.
    /// </summary>
    public sealed class SoundExtraInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundExtraInfoBlock"/> class.
        /// </summary>
        public SoundExtraInfoBlock()
        {
            this.Fields.Add(new BlockField<SoundDefinitionLanguagePermutationInfoBlock>("language permutation info", 576));
            this.Fields.Add(new BlockField<SoundEncodedDialogueSectionBlock>("encoded permutation section", 1));
            this.Fields.Add(new StructField<GlobalGeometryBlockInfoStructBlock>("geometry block info"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_extra_info_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_extra_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_extra_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_extra_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_extra_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_extra_info_block tag block.
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
