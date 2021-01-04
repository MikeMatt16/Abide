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
    /// Represents the generated damage_animation_block tag block.
    /// </summary>
    public sealed class DamageAnimationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageAnimationBlock"/> class.
        /// </summary>
        public DamageAnimationBlock()
        {
            this.Fields.Add(new StringIdField("label^"));
            this.Fields.Add(new BlockField<DamageDirectionBlock>("directions*", 4));
        }
        /// <summary>
        /// Gets and returns the name of the damage_animation_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "damage_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the damage_animation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "damage_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the damage_animation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the damage_animation_block tag block.
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
