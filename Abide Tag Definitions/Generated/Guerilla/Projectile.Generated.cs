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
    /// Represents the generated projectile (proj) tag group.
    /// </summary>
    public class Projectile : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Projectile"/> class.
        /// </summary>
        public Projectile()
        {
            // Add parent object tag block to list.
            this.TagBlocks.Add(new ObjectBlock());
            // Add tag block to list.
            this.TagBlocks.Add(new ProjectileBlock());
        }
        /// <summary>
        /// Gets and returns the name of the projectile tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "projectile";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the projectile tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "proj";
            }
        }
    }
}
