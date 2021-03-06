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
    /// Represents the generated weapon (weap) tag group.
    /// </summary>
    public class Weapon : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class.
        /// </summary>
        public Weapon()
        {
            // Add parent object tag block to list.
            this.TagBlocks.Add(new ObjectBlock());
            // Add parent item tag block to list.
            this.TagBlocks.Add(new ItemBlock());
            // Add tag block to list.
            this.TagBlocks.Add(new WeaponBlock());
        }
        /// <summary>
        /// Gets and returns the name of the weapon tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "weapon";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the weapon tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "weap";
            }
        }
    }
}
