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
    /// Represents the generated weapon_class_lookup_block tag block.
    /// </summary>
    public sealed class WeaponClassLookupBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponClassLookupBlock"/> class.
        /// </summary>
        public WeaponClassLookupBlock()
        {
            this.Fields.Add(new StringIdField("weapon name^"));
            this.Fields.Add(new StringIdField("weapon class"));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_class_lookup_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "weapon_class_lookup_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_class_lookup_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_class_lookup_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_class_lookup_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_class_lookup_block tag block.
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
