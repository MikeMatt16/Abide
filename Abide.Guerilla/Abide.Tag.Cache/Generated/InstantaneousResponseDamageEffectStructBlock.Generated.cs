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
    /// Represents the generated instantaneous_response_damage_effect_struct_block tag block.
    /// </summary>
    public sealed class InstantaneousResponseDamageEffectStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstantaneousResponseDamageEffectStructBlock"/> class.
        /// </summary>
        public InstantaneousResponseDamageEffectStructBlock()
        {
            this.Fields.Add(new TagReferenceField("transition damage effect", 1785754657));
        }
        /// <summary>
        /// Gets and returns the name of the instantaneous_response_damage_effect_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "instantaneous_response_damage_effect_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the instantaneous_response_damage_effect_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "instantaneous_response_damage_effect_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the instantaneous_response_damage_effect_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the instantaneous_response_damage_effect_struct_block tag block.
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
