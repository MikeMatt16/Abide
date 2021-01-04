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
    /// Represents the generated skill_to_rank_mapping_block tag block.
    /// </summary>
    public sealed class SkillToRankMappingBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillToRankMappingBlock"/> class.
        /// </summary>
        public SkillToRankMappingBlock()
        {
            this.Fields.Add(new ShortBoundsField("skill bounds"));
        }
        /// <summary>
        /// Gets and returns the name of the skill_to_rank_mapping_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "skill_to_rank_mapping_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the skill_to_rank_mapping_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "skill_to_rank_mapping_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the skill_to_rank_mapping_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65535;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the skill_to_rank_mapping_block tag block.
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
