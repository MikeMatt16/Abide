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
    /// Represents the generated damage_group_block tag block.
    /// </summary>
    public sealed class DamageGroupBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageGroupBlock"/> class.
        /// </summary>
        public DamageGroupBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new BlockField<ArmorModifierBlock>("armor modifiers", 2147483647));
        }
        /// <summary>
        /// Gets and returns the name of the damage_group_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "damage_group_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the damage_group_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "damage_group_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the damage_group_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2147483647;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the damage_group_block tag block.
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
