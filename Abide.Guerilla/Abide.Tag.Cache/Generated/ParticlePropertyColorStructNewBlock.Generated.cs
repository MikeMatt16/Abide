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
    /// Represents the generated particle_property_color_struct_new_block tag block.
    /// </summary>
    public sealed class ParticlePropertyColorStructNewBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticlePropertyColorStructNewBlock"/> class.
        /// </summary>
        public ParticlePropertyColorStructNewBlock()
        {
            this.Fields.Add(new EnumField("Input Variable", "particle age", "particle emit time", "particle random 1", "particle random 2", "emitter age", "emitter random 1", "emitter random 2", "system lod", "game time", "effect a scale", "effect b scale", "particle rotation", "explosion animation", "explosion rotation", "particle random 3", "particle random 4", "location random"));
            this.Fields.Add(new EnumField("Range Variable", "particle age", "particle emit time", "particle random 1", "particle random 2", "emitter age", "emitter random 1", "emitter random 2", "system lod", "game time", "effect a scale", "effect b scale", "particle rotation", "explosion animation", "explosion rotation", "particle random 3", "particle random 4", "location random"));
            this.Fields.Add(new EnumField("Output Modifier", " ", "Plus", "Times"));
            this.Fields.Add(new EnumField("Output Modifier Input", "particle age", "particle emit time", "particle random 1", "particle random 2", "emitter age", "emitter random 1", "emitter random 2", "system lod", "game time", "effect a scale", "effect b scale", "particle rotation", "explosion animation", "explosion rotation", "particle random 3", "particle random 4", "location random"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("Mapping"));
        }
        /// <summary>
        /// Gets and returns the name of the particle_property_color_struct_new_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "particle_property_color_struct_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the particle_property_color_struct_new_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "particle_property_color_struct_new";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the particle_property_color_struct_new_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the particle_property_color_struct_new_block tag block.
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
