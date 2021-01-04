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
    /// Represents the generated melee_damage_parameters_struct_block tag block.
    /// </summary>
    public sealed class MeleeDamageParametersStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeleeDamageParametersStructBlock"/> class.
        /// </summary>
        public MeleeDamageParametersStructBlock()
        {
            this.Fields.Add(new EulerAngles2dField("damage pyramid angles"));
            this.Fields.Add(new RealField("damage pyramid depth"));
            this.Fields.Add(new ExplanationField("melee combo damage", ""));
            this.Fields.Add(new TagReferenceField("1st hit melee damage", 1785754657));
            this.Fields.Add(new TagReferenceField("1st hit melee response", 1785754657));
            this.Fields.Add(new TagReferenceField("2nd hit melee damage", 1785754657));
            this.Fields.Add(new TagReferenceField("2nd hit melee response", 1785754657));
            this.Fields.Add(new TagReferenceField("3rd hit melee damage", 1785754657));
            this.Fields.Add(new TagReferenceField("3rd hit melee response", 1785754657));
            this.Fields.Add(new TagReferenceField("lunge melee damage#this is only important for the energy sword", 1785754657));
            this.Fields.Add(new TagReferenceField("lunge melee response#this is only important for the energy sword", 1785754657));
        }
        /// <summary>
        /// Gets and returns the name of the melee_damage_parameters_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "melee_damage_parameters_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the melee_damage_parameters_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "melee_damage_parameters_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the melee_damage_parameters_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the melee_damage_parameters_struct_block tag block.
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
