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
    using System.IO;
    
    [FieldSetAttribute(220, 4)]
    [TagGroupAttribute("sky", 1936423200u, 4294967293u, typeof(SkyBlock))]
    public sealed class SkyBlock : AbideTagBlock
    {
        private TagBlockList<SkyCubemapBlock> cubeMapList = new TagBlockList<SkyCubemapBlock>(1);
        private TagBlockList<SkyAtmosphericFogBlock> atmosphericFogList = new TagBlockList<SkyAtmosphericFogBlock>(1);
        private TagBlockList<SkyFogBlock> skyFogList = new TagBlockList<SkyFogBlock>(1);
        private TagBlockList<SkyPatchyFogBlock> patchyFogList = new TagBlockList<SkyPatchyFogBlock>(1);
        private TagBlockList<SkyLightBlock> lightsList = new TagBlockList<SkyLightBlock>(8);
        private TagBlockList<SkyShaderFunctionBlock> shaderFunctionsList = new TagBlockList<SkyShaderFunctionBlock>(8);
        private TagBlockList<SkyAnimationBlock> animationsList = new TagBlockList<SkyAnimationBlock>(8);
        [FieldAttribute("Render Model", typeof(TagReference))]
        public TagReference RenderModel;
        [FieldAttribute("Animation Graph", typeof(TagReference))]
        public TagReference AnimationGraph;
        [FieldAttribute("Flags", typeof(FlagsOptions))]
        [OptionsAttribute(typeof(FlagsOptions), true)]
        public FlagsOptions Flags;
        [FieldAttribute("Render Model Scale#Multiplier by which to scale the model\'s geometry up or down (" +
            "0 defaults to standard, 0.03).", typeof(Single))]
        public Single RenderModelScale;
        [FieldAttribute("Movement Scale#How much the sky moves to remain centered on the player (0 default" +
            "s to 1.0, which means no parallax).", typeof(Single))]
        public Single MovementScale;
        [FieldAttribute("Cube Map", typeof(TagBlock))]
        [BlockAttribute("sky_cubemap_block", 1, typeof(SkyCubemapBlock))]
        public TagBlock CubeMap;
        [FieldAttribute("Indoor Ambient Color#Indoor ambient light color.", typeof(ColorRgbF))]
        public ColorRgbF IndoorAmbientColor;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(4)]
        public Byte[] EmptyString;
        [FieldAttribute("Outdoor Ambient Color#Indoor ambient light color.", typeof(ColorRgbF))]
        public ColorRgbF OutdoorAmbientColor;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(4)]
        public Byte[] EmptyString1;
        [FieldAttribute("Fog Spread Distance:world units#How far fog spreads into adjacent clusters.", typeof(Single))]
        public Single FogSpreadDistance;
        [FieldAttribute("Atmospheric Fog", typeof(TagBlock))]
        [BlockAttribute("sky_atmospheric_fog_block", 1, typeof(SkyAtmosphericFogBlock))]
        public TagBlock AtmosphericFog;
        [FieldAttribute("Secondary Fog", typeof(TagBlock))]
        [BlockAttribute("sky_atmospheric_fog_block", 1, typeof(SkyAtmosphericFogBlock))]
        public TagBlock SecondaryFog;
        [FieldAttribute("Sky Fog", typeof(TagBlock))]
        [BlockAttribute("sky_fog_block", 1, typeof(SkyFogBlock))]
        public TagBlock SkyFog;
        [FieldAttribute("Patchy Fog", typeof(TagBlock))]
        [BlockAttribute("sky_patchy_fog_block", 1, typeof(SkyPatchyFogBlock))]
        public TagBlock PatchyFog;
        [FieldAttribute("Amount:[0,1]", typeof(Single))]
        public Single Amount;
        [FieldAttribute("Threshold:[0,1]", typeof(Single))]
        public Single Threshold;
        [FieldAttribute("Brightness:[0,1]", typeof(Single))]
        public Single Brightness;
        [FieldAttribute("Gamma Power", typeof(Single))]
        public Single GammaPower;
        [FieldAttribute("Lights", typeof(TagBlock))]
        [BlockAttribute("sky_light_block", 8, typeof(SkyLightBlock))]
        public TagBlock Lights;
        [FieldAttribute("Global Sky Rotation", typeof(Single))]
        public Single GlobalSkyRotation;
        [FieldAttribute("Shader Functions", typeof(TagBlock))]
        [BlockAttribute("sky_shader_function_block", 8, typeof(SkyShaderFunctionBlock))]
        public TagBlock ShaderFunctions;
        [FieldAttribute("Animations", typeof(TagBlock))]
        [BlockAttribute("sky_animation_block", 8, typeof(SkyAnimationBlock))]
        public TagBlock Animations;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(12)]
        public Byte[] EmptyString2;
        [FieldAttribute("Clear Color", typeof(ColorRgbF))]
        public ColorRgbF ClearColor;
        public TagBlockList<SkyCubemapBlock> CubeMapList
        {
            get
            {
                return this.cubeMapList;
            }
        }
        public TagBlockList<SkyAtmosphericFogBlock> AtmosphericFogList
        {
            get
            {
                return this.atmosphericFogList;
            }
        }
        public TagBlockList<SkyFogBlock> SkyFogList
        {
            get
            {
                return this.skyFogList;
            }
        }
        public TagBlockList<SkyPatchyFogBlock> PatchyFogList
        {
            get
            {
                return this.patchyFogList;
            }
        }
        public TagBlockList<SkyLightBlock> LightsList
        {
            get
            {
                return this.lightsList;
            }
        }
        public TagBlockList<SkyShaderFunctionBlock> ShaderFunctionsList
        {
            get
            {
                return this.shaderFunctionsList;
            }
        }
        public TagBlockList<SkyAnimationBlock> AnimationsList
        {
            get
            {
                return this.animationsList;
            }
        }
        public override int Size
        {
            get
            {
                return 220;
            }
        }
        public override void Initialize()
        {
            this.cubeMapList.Clear();
            this.atmosphericFogList.Clear();
            this.skyFogList.Clear();
            this.patchyFogList.Clear();
            this.lightsList.Clear();
            this.shaderFunctionsList.Clear();
            this.animationsList.Clear();
            this.RenderModel = TagReference.Null;
            this.AnimationGraph = TagReference.Null;
            this.Flags = ((FlagsOptions)(0));
            this.RenderModelScale = 0;
            this.MovementScale = 0;
            this.CubeMap = TagBlock.Zero;
            this.IndoorAmbientColor = ColorRgbF.Zero;
            this.EmptyString = new byte[4];
            this.OutdoorAmbientColor = ColorRgbF.Zero;
            this.EmptyString1 = new byte[4];
            this.FogSpreadDistance = 0;
            this.AtmosphericFog = TagBlock.Zero;
            this.SecondaryFog = TagBlock.Zero;
            this.SkyFog = TagBlock.Zero;
            this.PatchyFog = TagBlock.Zero;
            this.Amount = 0;
            this.Threshold = 0;
            this.Brightness = 0;
            this.GammaPower = 0;
            this.Lights = TagBlock.Zero;
            this.GlobalSkyRotation = 0;
            this.ShaderFunctions = TagBlock.Zero;
            this.Animations = TagBlock.Zero;
            this.EmptyString2 = new byte[12];
            this.ClearColor = ColorRgbF.Zero;
        }
        public override void Read(BinaryReader reader)
        {
            this.RenderModel = reader.Read<TagReference>();
            this.AnimationGraph = reader.Read<TagReference>();
            this.Flags = ((FlagsOptions)(reader.ReadInt32()));
            this.RenderModelScale = reader.ReadSingle();
            this.MovementScale = reader.ReadSingle();
            this.CubeMap = reader.ReadInt64();
            this.cubeMapList.Read(reader, this.CubeMap);
            this.IndoorAmbientColor = reader.Read<ColorRgbF>();
            this.EmptyString = reader.ReadBytes(4);
            this.OutdoorAmbientColor = reader.Read<ColorRgbF>();
            this.EmptyString1 = reader.ReadBytes(4);
            this.FogSpreadDistance = reader.ReadSingle();
            this.AtmosphericFog = reader.ReadInt64();
            this.atmosphericFogList.Read(reader, this.AtmosphericFog);
            this.SecondaryFog = reader.ReadInt64();
            this.atmosphericFogList.Read(reader, this.SecondaryFog);
            this.SkyFog = reader.ReadInt64();
            this.skyFogList.Read(reader, this.SkyFog);
            this.PatchyFog = reader.ReadInt64();
            this.patchyFogList.Read(reader, this.PatchyFog);
            this.Amount = reader.ReadSingle();
            this.Threshold = reader.ReadSingle();
            this.Brightness = reader.ReadSingle();
            this.GammaPower = reader.ReadSingle();
            this.Lights = reader.ReadInt64();
            this.lightsList.Read(reader, this.Lights);
            this.GlobalSkyRotation = reader.ReadSingle();
            this.ShaderFunctions = reader.ReadInt64();
            this.shaderFunctionsList.Read(reader, this.ShaderFunctions);
            this.Animations = reader.ReadInt64();
            this.animationsList.Read(reader, this.Animations);
            this.EmptyString2 = reader.ReadBytes(12);
            this.ClearColor = reader.Read<ColorRgbF>();
        }
        public override void Write(BinaryWriter writer)
        {
        }
        [FieldSetAttribute(20, 4)]
        public sealed class SkyCubemapBlock : AbideTagBlock
        {
            [FieldAttribute("Cube Map Reference", typeof(TagReference))]
            public TagReference CubeMapReference;
            [FieldAttribute("Power Scale#0 Defaults to 1.", typeof(Single))]
            public Single PowerScale;
            public override int Size
            {
                get
                {
                    return 20;
                }
            }
            public override void Initialize()
            {
                this.CubeMapReference = TagReference.Null;
                this.PowerScale = 0;
            }
            public override void Read(BinaryReader reader)
            {
                this.CubeMapReference = reader.Read<TagReference>();
                this.PowerScale = reader.ReadSingle();
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
        [FieldSetAttribute(24, 4)]
        public sealed class SkyAtmosphericFogBlock : AbideTagBlock
        {
            [FieldAttribute("Color", typeof(ColorRgbF))]
            public ColorRgbF Color;
            [FieldAttribute("Maximum Density:[0,1]#Fog density is clamped to this value.", typeof(Single))]
            public Single MaximumDensity;
            [FieldAttribute("Start Distance:world units#Before this distance there is no fog.", typeof(Single))]
            public Single StartDistance;
            [FieldAttribute("Opaque Distance:world units#Fog becomes opaque (maximum density) at this distance" +
                " from the viewer.", typeof(Single))]
            public Single OpaqueDistance;
            public override int Size
            {
                get
                {
                    return 24;
                }
            }
            public override void Initialize()
            {
                this.Color = ColorRgbF.Zero;
                this.MaximumDensity = 0;
                this.StartDistance = 0;
                this.OpaqueDistance = 0;
            }
            public override void Read(BinaryReader reader)
            {
                this.Color = reader.Read<ColorRgbF>();
                this.MaximumDensity = reader.ReadSingle();
                this.StartDistance = reader.ReadSingle();
                this.OpaqueDistance = reader.ReadSingle();
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
        [FieldSetAttribute(16, 4)]
        public sealed class SkyFogBlock : AbideTagBlock
        {
            [FieldAttribute("Color", typeof(ColorRgbF))]
            public ColorRgbF Color;
            [FieldAttribute("Density:[0,1]#Fog density is clamped to this value.", typeof(Single))]
            public Single Density;
            public override int Size
            {
                get
                {
                    return 16;
                }
            }
            public override void Initialize()
            {
                this.Color = ColorRgbF.Zero;
                this.Density = 0;
            }
            public override void Read(BinaryReader reader)
            {
                this.Color = reader.Read<ColorRgbF>();
                this.Density = reader.ReadSingle();
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
        [FieldSetAttribute(88, 4)]
        public sealed class SkyPatchyFogBlock : AbideTagBlock
        {
            [FieldAttribute("Color", typeof(ColorRgbF))]
            public ColorRgbF Color;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(12)]
            public Byte[] EmptyString;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(32)]
            public Byte[] EmptyString1;
            [FieldAttribute("Patchy Fog", typeof(TagReference))]
            public TagReference PatchyFog;
            public override int Size
            {
                get
                {
                    return 88;
                }
            }
            public override void Initialize()
            {
                this.Color = ColorRgbF.Zero;
                this.EmptyString = new byte[12];
                this.EmptyString1 = new byte[32];
                this.PatchyFog = TagReference.Null;
            }
            public override void Read(BinaryReader reader)
            {
                this.Color = reader.Read<ColorRgbF>();
                this.EmptyString = reader.ReadBytes(12);
                this.EmptyString1 = reader.ReadBytes(32);
                this.PatchyFog = reader.Read<TagReference>();
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
        [FieldSetAttribute(72, 4)]
        public sealed class SkyLightBlock : AbideTagBlock
        {
            private TagBlockList<SkyLightFogBlock> fogList = new TagBlockList<SkyLightFogBlock>(1);
            private TagBlockList<SkyRadiosityLightBlock> radiosityList = new TagBlockList<SkyRadiosityLightBlock>(1);
            [FieldAttribute("Direction Vector", typeof(Vector3))]
            public Vector3 DirectionVector;
            [FieldAttribute("Direction", typeof(Vector2))]
            public Vector2 Direction;
            [FieldAttribute("Lens Flare", typeof(TagReference))]
            public TagReference LensFlare;
            [FieldAttribute("Fog", typeof(TagBlock))]
            [BlockAttribute("sky_light_fog_block", 1, typeof(SkyLightFogBlock))]
            public TagBlock Fog;
            [FieldAttribute("Fog Opposite", typeof(TagBlock))]
            [BlockAttribute("sky_light_fog_block", 1, typeof(SkyLightFogBlock))]
            public TagBlock FogOpposite;
            [FieldAttribute("Radiosity", typeof(TagBlock))]
            [BlockAttribute("sky_radiosity_light_block", 1, typeof(SkyRadiosityLightBlock))]
            public TagBlock Radiosity;
            public TagBlockList<SkyLightFogBlock> FogList
            {
                get
                {
                    return this.fogList;
                }
            }
            public TagBlockList<SkyRadiosityLightBlock> RadiosityList
            {
                get
                {
                    return this.radiosityList;
                }
            }
            public override int Size
            {
                get
                {
                    return 72;
                }
            }
            public override void Initialize()
            {
                this.fogList.Clear();
                this.radiosityList.Clear();
                this.DirectionVector = Vector3.Zero;
                this.Direction = Vector2.Zero;
                this.LensFlare = TagReference.Null;
                this.Fog = TagBlock.Zero;
                this.FogOpposite = TagBlock.Zero;
                this.Radiosity = TagBlock.Zero;
            }
            public override void Read(BinaryReader reader)
            {
                this.DirectionVector = reader.Read<Vector3>();
                this.Direction = reader.Read<Vector2>();
                this.LensFlare = reader.Read<TagReference>();
                this.Fog = reader.ReadInt64();
                this.fogList.Read(reader, this.Fog);
                this.FogOpposite = reader.ReadInt64();
                this.fogList.Read(reader, this.FogOpposite);
                this.Radiosity = reader.ReadInt64();
                this.radiosityList.Read(reader, this.Radiosity);
            }
            public override void Write(BinaryWriter writer)
            {
            }
            [FieldSetAttribute(44, 4)]
            public sealed class SkyLightFogBlock : AbideTagBlock
            {
                [FieldAttribute("Color", typeof(ColorRgbF))]
                public ColorRgbF Color;
                [FieldAttribute("Maximum Density:[0,1]#Fog density is clamped to this value.", typeof(Single))]
                public Single MaximumDensity;
                [FieldAttribute("Start Distance:world units#Before this distance there is no fog.", typeof(Single))]
                public Single StartDistance;
                [FieldAttribute("Opaque Distance:world units#Fog becomes opaque (maximum density) at this distance" +
                    " from the viewer.", typeof(Single))]
                public Single OpaqueDistance;
                [FieldAttribute("Atmospheric Fog Influence:[0,1]", typeof(Single))]
                public Single AtmosphericFogInfluence;
                [FieldAttribute("Secondary Fog Influence:[0,1]", typeof(Single))]
                public Single SecondaryFogInfluence;
                [FieldAttribute("Sky Fog Influence:[0,1]", typeof(Single))]
                public Single SkyFogInfluence;
                public override int Size
                {
                    get
                    {
                        return 44;
                    }
                }
                public override void Initialize()
                {
                    this.Color = ColorRgbF.Zero;
                    this.MaximumDensity = 0;
                    this.StartDistance = 0;
                    this.OpaqueDistance = 0;
                    this.AtmosphericFogInfluence = 0;
                    this.SecondaryFogInfluence = 0;
                    this.SkyFogInfluence = 0;
                }
                public override void Read(BinaryReader reader)
                {
                    this.Color = reader.Read<ColorRgbF>();
                    this.MaximumDensity = reader.ReadSingle();
                    this.StartDistance = reader.ReadSingle();
                    this.OpaqueDistance = reader.ReadSingle();
                    this.AtmosphericFogInfluence = reader.ReadSingle();
                    this.SecondaryFogInfluence = reader.ReadSingle();
                    this.SkyFogInfluence = reader.ReadSingle();
                }
                public override void Write(BinaryWriter writer)
                {
                }
            }
            [FieldSetAttribute(40, 4)]
            public sealed class SkyRadiosityLightBlock : AbideTagBlock
            {
                [FieldAttribute("Flags", typeof(FlagsOptions))]
                [OptionsAttribute(typeof(FlagsOptions), true)]
                public FlagsOptions Flags;
                [FieldAttribute("Color:#Light color.", typeof(ColorRgbF))]
                public ColorRgbF Color;
                [FieldAttribute("Power:[0,+inf]#Light power from 0 to infinity.", typeof(Single))]
                public Single Power;
                [FieldAttribute("Test Distance:world units#Length of the ray for shadow testing.", typeof(Single))]
                public Single TestDistance;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(12)]
                public Byte[] EmptyString;
                [FieldAttribute("Diameter:degrees#Angular diameter of the light source in the sky.", typeof(Single))]
                public Single Diameter;
                public override int Size
                {
                    get
                    {
                        return 40;
                    }
                }
                public override void Initialize()
                {
                    this.Flags = ((FlagsOptions)(0));
                    this.Color = ColorRgbF.Zero;
                    this.Power = 0;
                    this.TestDistance = 0;
                    this.EmptyString = new byte[12];
                    this.Diameter = 0;
                }
                public override void Read(BinaryReader reader)
                {
                    this.Flags = ((FlagsOptions)(reader.ReadInt32()));
                    this.Color = reader.Read<ColorRgbF>();
                    this.Power = reader.ReadSingle();
                    this.TestDistance = reader.ReadSingle();
                    this.EmptyString = reader.ReadBytes(12);
                    this.Diameter = reader.ReadSingle();
                }
                public override void Write(BinaryWriter writer)
                {
                }
                public enum FlagsOptions : Int32
                {
                    AffectsExteriors = 1,
                    AffectsInteriors = 2,
                    DirectIlluminationInLightmaps = 4,
                    IndirectIlluminationInLightmaps = 8,
                }
            }
        }
        [FieldSetAttribute(36, 4)]
        public sealed class SkyShaderFunctionBlock : AbideTagBlock
        {
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(4)]
            public Byte[] EmptyString;
            [FieldAttribute("Global Function Name^#Global function that controls this shader value.", typeof(String32))]
            public String32 GlobalFunctionName;
            public override int Size
            {
                get
                {
                    return 36;
                }
            }
            public override void Initialize()
            {
                this.EmptyString = new byte[4];
                this.GlobalFunctionName = String32.Empty;
            }
            public override void Read(BinaryReader reader)
            {
                this.EmptyString = reader.ReadBytes(4);
                this.GlobalFunctionName = reader.Read<String32>();
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
        [FieldSetAttribute(36, 4)]
        public sealed class SkyAnimationBlock : AbideTagBlock
        {
            [FieldAttribute("Animation Index#Index of the animation in the animation graph.", typeof(Int16))]
            public Int16 AnimationIndex;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(2)]
            public Byte[] EmptyString;
            [FieldAttribute("Period:sec", typeof(Single))]
            public Single Period;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(28)]
            public Byte[] EmptyString1;
            public override int Size
            {
                get
                {
                    return 36;
                }
            }
            public override void Initialize()
            {
                this.AnimationIndex = 0;
                this.EmptyString = new byte[2];
                this.Period = 0;
                this.EmptyString1 = new byte[28];
            }
            public override void Read(BinaryReader reader)
            {
                this.AnimationIndex = reader.ReadInt16();
                this.EmptyString = reader.ReadBytes(2);
                this.Period = reader.ReadSingle();
                this.EmptyString1 = reader.ReadBytes(28);
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
        public enum FlagsOptions : Int32
        {
            FixedInWorldSpace = 1,
            Depreciated = 2,
            SkyCastsLightFromBelow = 4,
            DisableSkyInLightmaps = 8,
            FogOnlyAffectsContainingClusters = 16,
            UseClearColor = 32,
        }
    }
}
#pragma warning restore CS1591