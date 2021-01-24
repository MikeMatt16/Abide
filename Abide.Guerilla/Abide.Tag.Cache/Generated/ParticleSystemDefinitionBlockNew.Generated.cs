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
    /// Represents the generated particle_system_definition_block_new tag block.
    /// </summary>
    public sealed class ParticleSystemDefinitionBlockNew : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleSystemDefinitionBlockNew"/> class.
        /// </summary>
        public ParticleSystemDefinitionBlockNew()
        {
            this.Fields.Add(new TagReferenceField("particle", -3));
            this.Fields.Add(new LongBlockIndexField("location"));
            this.Fields.Add(new EnumField("coordinate system", "world", "local", "parent"));
            this.Fields.Add(new EnumField("environment", "any environment", "air only", "water only", "space only"));
            this.Fields.Add(new EnumField("disposition", "either mode", "violent mode only", "nonviolent mode only"));
            this.Fields.Add(new EnumField("camera mode", "independent of camera mode", "only in first person", "only in third person", "both first and third"));
            this.Fields.Add(new ShortIntegerField("sort bias#use values between -10 and 10 to move closer and farther from camera (p" +
                        "ositive is closer)"));
            this.Fields.Add(new WordFlagsField("flags", "glow", "cinematics", "looping particle", "disabled for debugging", "inherit effect velocity", "don\'t render system", "render when zoomed", "spread between ticks", "persistent particle", "expensive visibility"));
            this.Fields.Add(new RealField("LOD in distance#defaults to 0.0"));
            this.Fields.Add(new RealField("LOD feather in delta#defaults to 0.0"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealField("LOD out distance#defaults to 30.0"));
            this.Fields.Add(new RealField("LOD feather out delta#defaults to 10.0"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new BlockField<ParticleSystemEmitterDefinitionBlock>("emitters", 8));
        }
        /// <summary>
        /// Gets and returns the name of the particle_system_definition_block_new tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "particle_system_definition_block_new";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the particle_system_definition_block_new tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "particle_system_definition_block_new";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the particle_system_definition_block_new tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the particle_system_definition_block_new tag block.
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
