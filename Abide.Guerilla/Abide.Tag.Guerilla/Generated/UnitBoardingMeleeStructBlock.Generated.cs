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
    /// Represents the generated unit_boarding_melee_struct_block tag block.
    /// </summary>
    public sealed class UnitBoardingMeleeStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitBoardingMeleeStructBlock"/> class.
        /// </summary>
        public UnitBoardingMeleeStructBlock()
        {
            this.Fields.Add(new TagReferenceField("boarding melee damage", 1785754657));
            this.Fields.Add(new TagReferenceField("boarding melee response", 1785754657));
            this.Fields.Add(new TagReferenceField("landing melee damage", 1785754657));
            this.Fields.Add(new TagReferenceField("flurry melee damage", 1785754657));
            this.Fields.Add(new TagReferenceField("obstacle smash damage", 1785754657));
        }
        /// <summary>
        /// Gets and returns the name of the unit_boarding_melee_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_boarding_melee_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_boarding_melee_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_boarding_melee_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_boarding_melee_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_boarding_melee_struct_block tag block.
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
