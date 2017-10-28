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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(156, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("shader_template", 1937007981u, 4294967293u, typeof(ShaderTemplateBlock))]
    public sealed class ShaderTemplateBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("Default Material Name", typeof(StringId))]
        public StringId DefaultMaterialName;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags1;
        [Abide.Guerilla.Tags.FieldAttribute("Properties", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("property", 14, typeof(ShaderTemplatePropertyBlock))]
        public TagBlock Properties;
        [Abide.Guerilla.Tags.FieldAttribute("Categories", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("category", 16, typeof(ShaderTemplateCategoryBlock))]
        public TagBlock Categories;
        [Abide.Guerilla.Tags.FieldAttribute("Light Response", typeof(TagReference))]
        public TagReference LightResponse1;
        [Abide.Guerilla.Tags.FieldAttribute("LODs", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("shader_template_level_of_detail_block", 8, typeof(ShaderTemplateLevelOfDetailBlock))]
        public TagBlock Lods;
        [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("shader_template_runtime_external_light_response_index_block", 65535, typeof(ShaderTemplateRuntimeExternalLightResponseIndexBlock))]
        public TagBlock EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("shader_template_runtime_external_light_response_index_block", 65535, typeof(ShaderTemplateRuntimeExternalLightResponseIndexBlock))]
        public TagBlock EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("Aux 1 Shader", typeof(TagReference))]
        public TagReference Aux1Shader;
        [Abide.Guerilla.Tags.FieldAttribute("Aux 1 Layer", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Aux1LayerOptions), false)]
        public Int16 Aux1Layer;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("Aux 2 Shader", typeof(TagReference))]
        public TagReference Aux2Shader;
        [Abide.Guerilla.Tags.FieldAttribute("Aux 2 Layer", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Aux2LayerOptions), false)]
        public Int16 Aux2Layer;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("Postprocess Definition*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("shader_template_postprocess_definition_new_block", 1, typeof(ShaderTemplatePostprocessDefinitionNewBlock))]
        public TagBlock PostprocessDefinition;
        public int Size
        {
            get
            {
                return 156;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
        public sealed class ShaderTemplatePropertyBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Property^", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(PropertyOptions), false)]
            public Int16 Property;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("Parameter Name", typeof(StringId))]
            public StringId ParameterName;
            public int Size
            {
                get
                {
                    return 8;
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
            public enum PropertyOptions
            {
                Unused = 0,
                DiffuseMap = 1,
                LightmapEmissiveMap = 2,
                LightmapEmissiveColor = 3,
                LightmapEmissivePower = 4,
                LightmapResolutionScale = 5,
                LightmapHalfLife = 6,
                LightmapDiffuseScale = 7,
                LightmapAlphaTestMap = 8,
                LightmapTranslucentMap = 9,
                LightmapTranslucentColor = 10,
                LightmapTranslucentAlpha = 11,
                ActiveCamoMap = 12,
                LightmapFoliageScale = 13,
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(16, 4)]
        public sealed class ShaderTemplateCategoryBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(StringId))]
            public StringId Name;
            [Abide.Guerilla.Tags.FieldAttribute("Parameters", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("parameter", 64, typeof(ShaderTemplateParameterBlock))]
            public TagBlock Parameters;
            public int Size
            {
                get
                {
                    return 16;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(72, 4)]
            public sealed class ShaderTemplateParameterBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(StringId))]
                public StringId Name;
                [Abide.Guerilla.Tags.FieldAttribute("Type", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), false)]
                public Int16 Type;
                [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
                public Int16 Flags;
                [Abide.Guerilla.Tags.FieldAttribute("Default Bitmap", typeof(TagReference))]
                public TagReference DefaultBitmap;
                [Abide.Guerilla.Tags.FieldAttribute("Default Const Value", typeof(Single))]
                public Single DefaultConstValue;
                [Abide.Guerilla.Tags.FieldAttribute("Default Const Color", typeof(ColorRgbF))]
                public ColorRgbF DefaultConstColor;
                [Abide.Guerilla.Tags.FieldAttribute("Bitmap Type", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(BitmapTypeOptions), false)]
                public Int16 BitmapType;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(2)]
                public Byte[] EmptyString;
                [Abide.Guerilla.Tags.FieldAttribute("Bitmap Animation Flags", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(BitmapAnimationFlagsOptions), true)]
                public Int16 BitmapAnimationFlags;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(2)]
                public Byte[] EmptyString1;
                [Abide.Guerilla.Tags.FieldAttribute("Bitmap Scale", typeof(Single))]
                public Single BitmapScale;
                public int Size
                {
                    get
                    {
                        return 72;
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
                public enum TypeOptions
                {
                    Bitmap = 0,
                    Value = 1,
                    Color = 2,
                    Switch = 3,
                }
                public enum FlagsOptions
                {
                    Animated = 1,
                    HideBitmapReference = 2,
                }
                public enum BitmapTypeOptions
                {
                    _2d = 0,
                    _3d = 1,
                    CubeMap = 2,
                }
                public enum BitmapAnimationFlagsOptions
                {
                    ScaleUniform = 1,
                    Scale = 2,
                    Translation = 4,
                    Rotation = 8,
                    Index = 16,
                }
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(16, 4)]
        public sealed class ShaderTemplateLevelOfDetailBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("Projected Diameter:pixels", typeof(Single))]
            public Single ProjectedDiameter;
            [Abide.Guerilla.Tags.FieldAttribute("Pass", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("pass", 16, typeof(ShaderTemplatePassReferenceBlock))]
            public TagBlock Pass;
            public int Size
            {
                get
                {
                    return 16;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(32, 4)]
            public sealed class ShaderTemplatePassReferenceBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("Layer", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(LayerOptions), false)]
                public Int16 Layer;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(2)]
                public Byte[] EmptyString;
                [Abide.Guerilla.Tags.FieldAttribute("Pass^", typeof(TagReference))]
                public TagReference Pass;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(12)]
                public Byte[] EmptyString1;
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
                public enum LayerOptions
                {
                    Texaccum = 0,
                    EnvironmentMap = 1,
                    SelfIllumination = 2,
                    Overlay = 3,
                    Transparent = 4,
                    LightmapIndirect = 5,
                    Diffuse = 6,
                    Specular = 7,
                    ShadowGenerate = 8,
                    ShadowApply = 9,
                    Boom = 10,
                    Fog = 11,
                    ShPrt = 12,
                    ActiveCamo = 13,
                    WaterEdgeBlend = 14,
                    Decal = 15,
                    ActiveCamoStencilModulate = 16,
                    Hologram = 17,
                    LightAlbedo = 18,
                }
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(4, 4)]
        public sealed class ShaderTemplateRuntimeExternalLightResponseIndexBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("EMPTY STRING", typeof(Int32))]
            public Int32 EmptyString;
            public int Size
            {
                get
                {
                    return 4;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(60, 4)]
        public sealed class ShaderTemplatePostprocessDefinitionNewBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("levels of detail", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("shader_template_postprocess_level_of_detail_new_block", 1024, typeof(ShaderTemplatePostprocessLevelOfDetailNewBlock))]
            public TagBlock LevelsOfDetail;
            [Abide.Guerilla.Tags.FieldAttribute("layers", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("tag_block_index_block", 1024, typeof(TagBlockIndexBlock))]
            public TagBlock Layers;
            [Abide.Guerilla.Tags.FieldAttribute("passes", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("shader_template_postprocess_pass_new_block", 1024, typeof(ShaderTemplatePostprocessPassNewBlock))]
            public TagBlock Passes;
            [Abide.Guerilla.Tags.FieldAttribute("implementations", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("shader_template_postprocess_implementation_new_block", 1024, typeof(ShaderTemplatePostprocessImplementationNewBlock))]
            public TagBlock Implementations;
            [Abide.Guerilla.Tags.FieldAttribute("remappings", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("shader_template_postprocess_remapping_new_block", 1024, typeof(ShaderTemplatePostprocessRemappingNewBlock))]
            public TagBlock Remappings;
            public int Size
            {
                get
                {
                    return 60;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(10, 4)]
            public sealed class ShaderTemplatePostprocessLevelOfDetailNewBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("layers", typeof(TagBlockIndexStructBlock))]
                public TagBlockIndexStructBlock Layers;
                [Abide.Guerilla.Tags.FieldAttribute("available layers", typeof(Int32))]
                public Int32 AvailableLayers;
                [Abide.Guerilla.Tags.FieldAttribute("projected height percentage", typeof(Single))]
                public Single ProjectedHeightPercentage;
                public int Size
                {
                    get
                    {
                        return 10;
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
                [Abide.Guerilla.Tags.FieldSetAttribute(2, 4)]
                public sealed class TagBlockIndexStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                {
                    [Abide.Guerilla.Tags.FieldAttribute("block index data", typeof(Int16))]
                    public Int16 BlockIndexData;
                    public int Size
                    {
                        get
                        {
                            return 2;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(2, 4)]
            public sealed class TagBlockIndexBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("indices", typeof(TagBlockIndexStructBlock))]
                public TagBlockIndexStructBlock Indices;
                public int Size
                {
                    get
                    {
                        return 2;
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
                [Abide.Guerilla.Tags.FieldSetAttribute(2, 4)]
                public sealed class TagBlockIndexStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                {
                    [Abide.Guerilla.Tags.FieldAttribute("block index data", typeof(Int16))]
                    public Int16 BlockIndexData;
                    public int Size
                    {
                        get
                        {
                            return 2;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(18, 4)]
            public sealed class ShaderTemplatePostprocessPassNewBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("pass", typeof(TagReference))]
                public TagReference Pass;
                [Abide.Guerilla.Tags.FieldAttribute("implementations", typeof(TagBlockIndexStructBlock))]
                public TagBlockIndexStructBlock Implementations;
                public int Size
                {
                    get
                    {
                        return 18;
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
                [Abide.Guerilla.Tags.FieldSetAttribute(2, 4)]
                public sealed class TagBlockIndexStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                {
                    [Abide.Guerilla.Tags.FieldAttribute("block index data", typeof(Int16))]
                    public Int16 BlockIndexData;
                    public int Size
                    {
                        get
                        {
                            return 2;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(6, 4)]
            public sealed class ShaderTemplatePostprocessImplementationNewBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("bitmaps", typeof(TagBlockIndexStructBlock))]
                public TagBlockIndexStructBlock Bitmaps;
                [Abide.Guerilla.Tags.FieldAttribute("pixel constants", typeof(TagBlockIndexStructBlock))]
                public TagBlockIndexStructBlock PixelConstants;
                [Abide.Guerilla.Tags.FieldAttribute("vertex constants", typeof(TagBlockIndexStructBlock))]
                public TagBlockIndexStructBlock VertexConstants;
                public int Size
                {
                    get
                    {
                        return 6;
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
                [Abide.Guerilla.Tags.FieldSetAttribute(2, 4)]
                public sealed class TagBlockIndexStructBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
                {
                    [Abide.Guerilla.Tags.FieldAttribute("block index data", typeof(Int16))]
                    public Int16 BlockIndexData;
                    public int Size
                    {
                        get
                        {
                            return 2;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(4, 4)]
            public sealed class ShaderTemplatePostprocessRemappingNewBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(3)]
                public Byte[] EmptyString;
                [Abide.Guerilla.Tags.FieldAttribute("source index", typeof(Byte))]
                public Byte SourceIndex;
                public int Size
                {
                    get
                    {
                        return 4;
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
        public enum FlagsOptions
        {
            ForceActiveCamo = 1,
            Water = 2,
            Foliage = 4,
            HideStandardParameters = 8,
        }
        public enum Aux1LayerOptions
        {
            Texaccum = 0,
            EnvironmentMap = 1,
            SelfIllumination = 2,
            Overlay = 3,
            Transparent = 4,
            LightmapIndirect = 5,
            Diffuse = 6,
            Specular = 7,
            ShadowGenerate = 8,
            ShadowApply = 9,
            Boom = 10,
            Fog = 11,
            ShPrt = 12,
            ActiveCamo = 13,
            WaterEdgeBlend = 14,
            Decal = 15,
            ActiveCamoStencilModulate = 16,
            Hologram = 17,
            LightAlbedo = 18,
        }
        public enum Aux2LayerOptions
        {
            Texaccum = 0,
            EnvironmentMap = 1,
            SelfIllumination = 2,
            Overlay = 3,
            Transparent = 4,
            LightmapIndirect = 5,
            Diffuse = 6,
            Specular = 7,
            ShadowGenerate = 8,
            ShadowApply = 9,
            Boom = 10,
            Fog = 11,
            ShPrt = 12,
            ActiveCamo = 13,
            WaterEdgeBlend = 14,
            Decal = 15,
            ActiveCamoStencilModulate = 16,
            Hologram = 17,
            LightAlbedo = 18,
        }
    }
}
#pragma warning restore CS1591
