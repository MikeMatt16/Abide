#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(32, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("particle_physics", 1886220150u, 4294967293u, typeof(ParticlePhysicsBlock))]
    public sealed class ParticlePhysicsBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("template", typeof(TagReference))]
        public TagReference Template;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("movements", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("particle_controller", 4, typeof(ParticleController))]
        public TagBlock Movements;
        public int Size
        {
            get
            {
                return 32;
            }
        }
        public void Initialize()
        {
        }
        public void Read(System.IO.BinaryReader reader)
        {
        }
        public void Write(System.IO.BinaryWriter writer)
        {
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
        public sealed class ParticleController : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), false)]
            public Int16 Type;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("parameters", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("particle_controller_parameters", 9, typeof(ParticleControllerParameters))]
            public TagBlock Parameters;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(8)]
            public Byte[] EmptyString1;
            public int Size
            {
                get
                {
                    return 24;
                }
            }
            public void Initialize()
            {
            }
            public void Read(System.IO.BinaryReader reader)
            {
            }
            public void Write(System.IO.BinaryWriter writer)
            {
            }
            [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
            public sealed class ParticleControllerParameters : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("parameter id", typeof(Int32))]
                public Int32 ParameterId;
                [Abide.Guerilla.Tags.FieldAttribute("property", typeof(ParticlePropertyScalarStructNewBlock))]
                public ParticlePropertyScalarStructNewBlock Property;
                public int Size
                {
                    get
                    {
                        return 24;
                    }
                }
                public void Initialize()
                {
                }
                public void Read(System.IO.BinaryReader reader)
                {
                }
                public void Write(System.IO.BinaryWriter writer)
                {
                }
                [Abide.Guerilla.Tags.FieldSetAttribute(20, 4)]
                public sealed class ParticlePropertyScalarStructNewBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                {
                    [Abide.Guerilla.Tags.FieldAttribute("Input Variable", typeof(Int16))]
                    [Abide.Guerilla.Tags.OptionsAttribute(typeof(InputVariableOptions), false)]
                    public Int16 InputVariable;
                    [Abide.Guerilla.Tags.FieldAttribute("Range Variable", typeof(Int16))]
                    [Abide.Guerilla.Tags.OptionsAttribute(typeof(RangeVariableOptions), false)]
                    public Int16 RangeVariable;
                    [Abide.Guerilla.Tags.FieldAttribute("Output Modifier", typeof(Int16))]
                    [Abide.Guerilla.Tags.OptionsAttribute(typeof(OutputModifierOptions), false)]
                    public Int16 OutputModifier;
                    [Abide.Guerilla.Tags.FieldAttribute("Output Modifier Input", typeof(Int16))]
                    [Abide.Guerilla.Tags.OptionsAttribute(typeof(OutputModifierInputOptions), false)]
                    public Int16 OutputModifierInput;
                    [Abide.Guerilla.Tags.FieldAttribute("Mapping", typeof(MappingFunctionBlock))]
                    public MappingFunctionBlock Mapping1;
                    public int Size
                    {
                        get
                        {
                            return 20;
                        }
                    }
                    public void Initialize()
                    {
                    }
                    public void Read(System.IO.BinaryReader reader)
                    {
                    }
                    public void Write(System.IO.BinaryWriter writer)
                    {
                    }
                    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
                    public sealed class MappingFunctionBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                    {
                        [Abide.Guerilla.Tags.FieldAttribute("data", typeof(TagBlock))]
                        [Abide.Guerilla.Tags.BlockAttribute("byte_block", 1024, typeof(ByteBlock))]
                        public TagBlock Data;
                        public int Size
                        {
                            get
                            {
                                return 12;
                            }
                        }
                        public void Initialize()
                        {
                        }
                        public void Read(System.IO.BinaryReader reader)
                        {
                        }
                        public void Write(System.IO.BinaryWriter writer)
                        {
                        }
                        [Abide.Guerilla.Tags.FieldSetAttribute(1, 4)]
                        public sealed class ByteBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                        {
                            [Abide.Guerilla.Tags.FieldAttribute("Value", typeof(Byte))]
                            public Byte Value;
                            public int Size
                            {
                                get
                                {
                                    return 1;
                                }
                            }
                            public void Initialize()
                            {
                            }
                            public void Read(System.IO.BinaryReader reader)
                            {
                            }
                            public void Write(System.IO.BinaryWriter writer)
                            {
                            }
                        }
                    }
                    public enum InputVariableOptions
                    {
                        ParticleAge = 0,
                        ParticleEmitTime = 1,
                        ParticleRandom1 = 2,
                        ParticleRandom2 = 3,
                        EmitterAge = 4,
                        EmitterRandom1 = 5,
                        EmitterRandom2 = 6,
                        SystemLod = 7,
                        GameTime = 8,
                        EffectAScale = 9,
                        EffectBScale = 10,
                        ParticleRotation = 11,
                        ExplosionAnimation = 12,
                        ExplosionRotation = 13,
                        ParticleRandom3 = 14,
                        ParticleRandom4 = 15,
                        LocationRandom = 16,
                    }
                    public enum RangeVariableOptions
                    {
                        ParticleAge = 0,
                        ParticleEmitTime = 1,
                        ParticleRandom1 = 2,
                        ParticleRandom2 = 3,
                        EmitterAge = 4,
                        EmitterRandom1 = 5,
                        EmitterRandom2 = 6,
                        SystemLod = 7,
                        GameTime = 8,
                        EffectAScale = 9,
                        EffectBScale = 10,
                        ParticleRotation = 11,
                        ExplosionAnimation = 12,
                        ExplosionRotation = 13,
                        ParticleRandom3 = 14,
                        ParticleRandom4 = 15,
                        LocationRandom = 16,
                    }
                    public enum OutputModifierOptions
                    {
                        EmptyString = 0,
                        Plus = 1,
                        Times = 2,
                    }
                    public enum OutputModifierInputOptions
                    {
                        ParticleAge = 0,
                        ParticleEmitTime = 1,
                        ParticleRandom1 = 2,
                        ParticleRandom2 = 3,
                        EmitterAge = 4,
                        EmitterRandom1 = 5,
                        EmitterRandom2 = 6,
                        SystemLod = 7,
                        GameTime = 8,
                        EffectAScale = 9,
                        EffectBScale = 10,
                        ParticleRotation = 11,
                        ExplosionAnimation = 12,
                        ExplosionRotation = 13,
                        ParticleRandom3 = 14,
                        ParticleRandom4 = 15,
                        LocationRandom = 16,
                    }
                }
            }
            public enum TypeOptions
            {
                Physics = 0,
                Collider = 1,
                Swarm = 2,
                Wind = 3,
            }
        }
        public enum FlagsOptions
        {
            Physics = 1,
            CollideWithStructure = 2,
            CollideWithMedia = 4,
            CollideWithScenery = 8,
            CollideWithVehicles = 16,
            CollideWithBipeds = 32,
            Swarm = 64,
            Wind = 128,
        }
    }
}
#pragma warning restore CS1591
