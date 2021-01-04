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
    /// Represents the generated particle_model_block tag block.
    /// </summary>
    public sealed class ParticleModelBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleModelBlock"/> class.
        /// </summary>
        public ParticleModelBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "spins", "random u mirror", "random v mirror", "frame animation one shot", "select random sequence", "disable frame blending", "can animate backwards", "receive lightmap lighting", "tint from diffuse texture", "dies at rest", "dies on structure collision", "dies in media", "dies in air", "bitmap authored vertically", "has sweetener"));
            this.Fields.Add(new LongEnumField("orientation", "screen facing", "parallel to direction", "perpendicular to direction", "vertical", "horizontal"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new TagReferenceField("shader", 1936220516));
            this.Fields.Add(new ExplanationField("SCALE X", "scale of model on x axis"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("scale x"));
            this.Fields.Add(new ExplanationField("SCALE Y", "scale of model on y axis"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("scale y"));
            this.Fields.Add(new ExplanationField("SCALE Z", "scale of model on z axis"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("scale z"));
            this.Fields.Add(new ExplanationField("ROTATION", "rotation where 0=0 degrees, 0.5=180 degrees, 1.0=360 degrees"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("rotation"));
            this.Fields.Add(new ExplanationField("Spawned Effects", "collision occurs when particle physics has collision, death spawned when particle" +
                        " dies"));
            this.Fields.Add(new TagReferenceField("collision effect#effect, material effect or sound spawned when this particle coll" +
                        "ides with something", -3));
            this.Fields.Add(new TagReferenceField("death effect#effect, material effect or sound spawned when this particle dies", -3));
            this.Fields.Add(new ExplanationField("Attached Particle Systems", "Locations:\nup - particles shoot straight up\ngravity - particles shoot straight do" +
                        "wn\nNONE - opposite of particle direction"));
            this.Fields.Add(new BlockField<EffectLocationsBlock>("locations", 32));
            this.Fields.Add(new BlockField<ParticleSystemDefinitionBlockNew>("attached particle systems", 32));
            this.Fields.Add(new BlockField<ParticleModelsBlock>("models*", 256));
            this.Fields.Add(new BlockField<ParticleModelVerticesBlock>("raw vertices*", 32768));
            this.Fields.Add(new BlockField<ParticleModelIndicesBlock>("indices*", 32768));
            this.Fields.Add(new BlockField<CachedDataBlock>("cached data", 1));
            this.Fields.Add(new StructField<GlobalGeometryBlockInfoStructBlock>("geometry section info"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 8));
        }
        /// <summary>
        /// Gets and returns the name of the particle_model_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "particle_model_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the particle_model_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "particle_model";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the particle_model_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the particle_model_block tag block.
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