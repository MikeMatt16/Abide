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
    /// Represents the generated unit_weapon_block tag block.
    /// </summary>
    public sealed class UnitWeaponBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitWeaponBlock"/> class.
        /// </summary>
        public UnitWeaponBlock()
        {
            this.Fields.Add(new TagReferenceField("weapon^", 2003132784));
        }
        /// <summary>
        /// Gets and returns the name of the unit_weapon_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_weapon_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_weapon_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_weapon_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_weapon_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_weapon_block tag block.
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
