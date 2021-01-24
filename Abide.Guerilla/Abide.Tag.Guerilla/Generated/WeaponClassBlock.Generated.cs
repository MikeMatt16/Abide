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
    /// Represents the generated weapon_class_block tag block.
    /// </summary>
    public sealed class WeaponClassBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponClassBlock"/> class.
        /// </summary>
        public WeaponClassBlock()
        {
            this.Fields.Add(new StringIdField("label^"));
            this.Fields.Add(new BlockField<WeaponTypeBlock>("weapon type|AABBCC", 64));
            this.Fields.Add(new BlockField<AnimationIkBlock>("weapon ik|AABBCC", 8));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_class_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "weapon_class_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_class_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_class_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_class_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_class_block tag block.
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
