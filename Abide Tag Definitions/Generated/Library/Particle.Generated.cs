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
    /// Represents the generated particle (prt3) tag group.
    /// </summary>
    public class Particle : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Particle"/> class.
        /// </summary>
        public Particle()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ParticleBlock());
        }
        /// <summary>
        /// Gets and returns the name of the particle tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "particle";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the particle tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "prt3";
            }
        }
    }
}
