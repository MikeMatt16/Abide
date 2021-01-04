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
    /// Represents the generated particle_controller_parameters tag block.
    /// </summary>
    public sealed class ParticleControllerParameters : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleControllerParameters"/> class.
        /// </summary>
        public ParticleControllerParameters()
        {
            this.Fields.Add(new LongIntegerField("parameter id"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("property"));
        }
        /// <summary>
        /// Gets and returns the name of the particle_controller_parameters tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "particle_controller_parameters";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the particle_controller_parameters tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "particle_controller_parameters";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the particle_controller_parameters tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 9;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the particle_controller_parameters tag block.
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
