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
    /// Represents the generated particle_model (PRTM) tag group.
    /// </summary>
    public class ParticleModel : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleModel"/> class.
        /// </summary>
        public ParticleModel()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ParticleModelBlock());
        }
        /// <summary>
        /// Gets and returns the name of the particle_model tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "particle_model";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the particle_model tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "PRTM";
            }
        }
    }
}
