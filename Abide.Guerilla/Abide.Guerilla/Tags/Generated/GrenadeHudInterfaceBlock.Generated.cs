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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(504, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("grenade_hud_interface", 1735551081u, 4294967293u, typeof(GrenadeHudInterfaceBlock))]
    public sealed class GrenadeHudInterfaceBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("anchor", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(AnchorOptions), false)]
        public Int16 Anchor;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
        public Vector2 AnchorOffset;
        [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
        public Single WidthScale;
        [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
        public Single HeightScale;
        [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions), true)]
        public Int16 ScalingFlags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("interface bitmap", typeof(TagReference))]
        public TagReference InterfaceBitmap;
        [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
        public ColorArgb DefaultColor;
        [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
        public ColorArgb FlashingColor;
        [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
        public Single FlashPeriod;
        [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
        public Single FlashDelay;
        [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
        public Int16 NumberOfFlashes;
        [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions), true)]
        public Int16 FlashFlags;
        [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
        public Single FlashLength;
        [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
        public ColorArgb DisabledColor;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index", typeof(Int16))]
        public Int16 SequenceIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString6;
        [Abide.Guerilla.Tags.FieldAttribute("multitex overlay", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("global_hud_multitexture_overlay_definition", 30, typeof(GlobalHudMultitextureOverlayDefinition))]
        public TagBlock MultitexOverlay;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString7;
        [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
        public Vector2 AnchorOffset1;
        [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
        public Single WidthScale1;
        [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
        public Single HeightScale1;
        [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions1), true)]
        public Int16 ScalingFlags1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString8;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString9;
        [Abide.Guerilla.Tags.FieldAttribute("interface bitmap", typeof(TagReference))]
        public TagReference InterfaceBitmap1;
        [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
        public ColorArgb DefaultColor1;
        [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
        public ColorArgb FlashingColor1;
        [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
        public Single FlashPeriod1;
        [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
        public Single FlashDelay1;
        [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
        public Int16 NumberOfFlashes1;
        [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions1), true)]
        public Int16 FlashFlags1;
        [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
        public Single FlashLength1;
        [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
        public ColorArgb DisabledColor1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString10;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index", typeof(Int16))]
        public Int16 SequenceIndex1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString11;
        [Abide.Guerilla.Tags.FieldAttribute("multitex overlay", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("global_hud_multitexture_overlay_definition", 30, typeof(GlobalHudMultitextureOverlayDefinition))]
        public TagBlock MultitexOverlay1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString12;
        [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
        public Vector2 AnchorOffset2;
        [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
        public Single WidthScale2;
        [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
        public Single HeightScale2;
        [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions2), true)]
        public Int16 ScalingFlags2;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString13;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString14;
        [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
        public ColorArgb DefaultColor2;
        [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
        public ColorArgb FlashingColor2;
        [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
        public Single FlashPeriod2;
        [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
        public Single FlashDelay2;
        [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
        public Int16 NumberOfFlashes2;
        [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions2), true)]
        public Int16 FlashFlags2;
        [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
        public Single FlashLength2;
        [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
        public ColorArgb DisabledColor2;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString15;
        [Abide.Guerilla.Tags.FieldAttribute("maximum number of digits", typeof(Byte))]
        public Byte MaximumNumberOfDigits;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Byte Flags;
        [Abide.Guerilla.Tags.FieldAttribute("number of fractional digits", typeof(Byte))]
        public Byte NumberOfFractionalDigits;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(1)]
        public Byte[] EmptyString16;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString17;
        [Abide.Guerilla.Tags.FieldAttribute("flash cutoff", typeof(Int16))]
        public Int16 FlashCutoff;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString18;
        [Abide.Guerilla.Tags.FieldAttribute("Overlay bitmap", typeof(TagReference))]
        public TagReference OverlayBitmap;
        [Abide.Guerilla.Tags.FieldAttribute("Overlays", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("grenade_hud_overlay_block", 16, typeof(GrenadeHudOverlayBlock))]
        public TagBlock Overlays;
        [Abide.Guerilla.Tags.FieldAttribute("Warning sounds", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("grenade_hud_sound_block", 12, typeof(GrenadeHudSoundBlock))]
        public TagBlock WarningSounds;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(68)]
        public Byte[] EmptyString19;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index#sequence index into the global hud icon bitmap", typeof(Int16))]
        public Int16 SequenceIndex2;
        [Abide.Guerilla.Tags.FieldAttribute("width offset#extra spacing beyond bitmap width for text alignment", typeof(Int16))]
        public Int16 WidthOffset;
        [Abide.Guerilla.Tags.FieldAttribute("offset from reference corner", typeof(Vector2))]
        public Vector2 OffsetFromReferenceCorner;
        [Abide.Guerilla.Tags.FieldAttribute("override icon color", typeof(ColorArgb))]
        public ColorArgb OverrideIconColor;
        [Abide.Guerilla.Tags.FieldAttribute("frame rate [0,30]", typeof(Byte))]
        public Byte FrameRate030;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions1), true)]
        public Byte Flags1;
        [Abide.Guerilla.Tags.FieldAttribute("text index", typeof(Int16))]
        public Int16 TextIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(48)]
        public Byte[] EmptyString20;
        public int Size
        {
            get
            {
                return 504;
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
        [Abide.Guerilla.Tags.FieldSetAttribute(480, 4)]
        public sealed class GlobalHudMultitextureOverlayDefinition : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Int16))]
            public Int16 Type;
            [Abide.Guerilla.Tags.FieldAttribute("framebuffer blend func", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(FramebufferBlendFuncOptions), false)]
            public Int16 FramebufferBlendFunc;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString1;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(32)]
            public Byte[] EmptyString2;
            [Abide.Guerilla.Tags.FieldAttribute("primary anchor", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(PrimaryAnchorOptions), false)]
            public Int16 PrimaryAnchor;
            [Abide.Guerilla.Tags.FieldAttribute("secondary anchor", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(SecondaryAnchorOptions), false)]
            public Int16 SecondaryAnchor;
            [Abide.Guerilla.Tags.FieldAttribute("tertiary anchor", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(TertiaryAnchorOptions), false)]
            public Int16 TertiaryAnchor;
            [Abide.Guerilla.Tags.FieldAttribute("0 to 1 blend func", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(_0To1BlendFuncOptions), false)]
            public Int16 _0To1BlendFunc;
            [Abide.Guerilla.Tags.FieldAttribute("1 to 2 blend func", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(_1To2BlendFuncOptions), false)]
            public Int16 _1To2BlendFunc;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString3;
            [Abide.Guerilla.Tags.FieldAttribute("primary scale", typeof(Vector2))]
            public Vector2 PrimaryScale;
            [Abide.Guerilla.Tags.FieldAttribute("secondary scale", typeof(Vector2))]
            public Vector2 SecondaryScale;
            [Abide.Guerilla.Tags.FieldAttribute("tertiary scale", typeof(Vector2))]
            public Vector2 TertiaryScale;
            [Abide.Guerilla.Tags.FieldAttribute("primary offset", typeof(Vector2))]
            public Vector2 PrimaryOffset;
            [Abide.Guerilla.Tags.FieldAttribute("secondary offset", typeof(Vector2))]
            public Vector2 SecondaryOffset;
            [Abide.Guerilla.Tags.FieldAttribute("tertiary offset", typeof(Vector2))]
            public Vector2 TertiaryOffset;
            [Abide.Guerilla.Tags.FieldAttribute("primary", typeof(TagReference))]
            public TagReference Primary;
            [Abide.Guerilla.Tags.FieldAttribute("secondary", typeof(TagReference))]
            public TagReference Secondary;
            [Abide.Guerilla.Tags.FieldAttribute("tertiary", typeof(TagReference))]
            public TagReference Tertiary;
            [Abide.Guerilla.Tags.FieldAttribute("primary wrap mode", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(PrimaryWrapModeOptions), false)]
            public Int16 PrimaryWrapMode;
            [Abide.Guerilla.Tags.FieldAttribute("secondary wrap mode", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(SecondaryWrapModeOptions), false)]
            public Int16 SecondaryWrapMode;
            [Abide.Guerilla.Tags.FieldAttribute("tertiary wrap mode", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(TertiaryWrapModeOptions), false)]
            public Int16 TertiaryWrapMode;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString4;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(184)]
            public Byte[] EmptyString5;
            [Abide.Guerilla.Tags.FieldAttribute("effectors", typeof(TagBlock))]
            [Abide.Guerilla.Tags.BlockAttribute("global_hud_multitexture_overlay_effector_definition", 30, typeof(GlobalHudMultitextureOverlayEffectorDefinition))]
            public TagBlock Effectors;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(128)]
            public Byte[] EmptyString6;
            public int Size
            {
                get
                {
                    return 480;
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
            [Abide.Guerilla.Tags.FieldSetAttribute(220, 4)]
            public sealed class GlobalHudMultitextureOverlayEffectorDefinition : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
            {
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(64)]
                public Byte[] EmptyString;
                [Abide.Guerilla.Tags.FieldAttribute("destination type", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(DestinationTypeOptions), false)]
                public Int16 DestinationType;
                [Abide.Guerilla.Tags.FieldAttribute("destination", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(DestinationOptions), false)]
                public Int16 Destination;
                [Abide.Guerilla.Tags.FieldAttribute("source", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(SourceOptions), false)]
                public Int16 Source;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(2)]
                public Byte[] EmptyString1;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(64)]
                public Byte[] EmptyString2;
                [Abide.Guerilla.Tags.FieldAttribute("tint color lower bound", typeof(ColorRgbF))]
                public ColorRgbF TintColorLowerBound;
                [Abide.Guerilla.Tags.FieldAttribute("tint color upper bound", typeof(ColorRgbF))]
                public ColorRgbF TintColorUpperBound;
                [Abide.Guerilla.Tags.FieldAttribute("periodic function", typeof(Int16))]
                [Abide.Guerilla.Tags.OptionsAttribute(typeof(PeriodicFunctionOptions), false)]
                public Int16 PeriodicFunction;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(2)]
                public Byte[] EmptyString3;
                [Abide.Guerilla.Tags.FieldAttribute("function period:seconds", typeof(Single))]
                public Single FunctionPeriod;
                [Abide.Guerilla.Tags.FieldAttribute("function phase:seconds", typeof(Single))]
                public Single FunctionPhase;
                [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
                [Abide.Guerilla.Tags.PaddingAttribute(32)]
                public Byte[] EmptyString4;
                public int Size
                {
                    get
                    {
                        return 220;
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
                public enum DestinationTypeOptions
                {
                    Tint01 = 0,
                    HorizontalOffset = 1,
                    VerticalOffset = 2,
                    Fade01 = 3,
                }
                public enum DestinationOptions
                {
                    GeometryOffset = 0,
                    PrimaryMap = 1,
                    SecondaryMap = 2,
                    TertiaryMap = 3,
                }
                public enum SourceOptions
                {
                    PlayerPitch = 0,
                    PlayerPitchTangent = 1,
                    PlayerYaw = 2,
                    WeaponRoundsLoaded = 3,
                    WeaponRoundsInventory = 4,
                    WeaponHeat = 5,
                    ExplicitUsesLowBound = 6,
                    WeaponZoomLevel = 7,
                }
                public enum PeriodicFunctionOptions
                {
                    One = 0,
                    Zero = 1,
                    Cosine = 2,
                    CosineVariablePeriod = 3,
                    DiagonalWave = 4,
                    DiagonalWaveVariablePeriod = 5,
                    Slide = 6,
                    SlideVariablePeriod = 7,
                    Noise = 8,
                    Jitter = 9,
                    Wander = 10,
                    Spark = 11,
                }
            }
            public enum FramebufferBlendFuncOptions
            {
                AlphaBlend = 0,
                Multiply = 1,
                DoubleMultiply = 2,
                Add = 3,
                Subtract = 4,
                ComponentMin = 5,
                ComponentMax = 6,
                AlphaMultiplyAdd = 7,
                ConstantColorBlend = 8,
                InverseConstantColorBlend = 9,
                None = 10,
            }
            public enum PrimaryAnchorOptions
            {
                Texture = 0,
                Screen = 1,
            }
            public enum SecondaryAnchorOptions
            {
                Texture = 0,
                Screen = 1,
            }
            public enum TertiaryAnchorOptions
            {
                Texture = 0,
                Screen = 1,
            }
            public enum _0To1BlendFuncOptions
            {
                Add = 0,
                Subtract = 1,
                Multiply = 2,
                Multiply2x = 3,
                Dot = 4,
            }
            public enum _1To2BlendFuncOptions
            {
                Add = 0,
                Subtract = 1,
                Multiply = 2,
                Multiply2x = 3,
                Dot = 4,
            }
            public enum PrimaryWrapModeOptions
            {
                Clamp = 0,
                Wrap = 1,
            }
            public enum SecondaryWrapModeOptions
            {
                Clamp = 0,
                Wrap = 1,
            }
            public enum TertiaryWrapModeOptions
            {
                Clamp = 0,
                Wrap = 1,
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(136, 4)]
        public sealed class GrenadeHudOverlayBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
            public Vector2 AnchorOffset;
            [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
            public Single WidthScale;
            [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
            public Single HeightScale;
            [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions), true)]
            public Int16 ScalingFlags;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(2)]
            public Byte[] EmptyString;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(20)]
            public Byte[] EmptyString1;
            [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
            public ColorArgb DefaultColor;
            [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
            public ColorArgb FlashingColor;
            [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
            public Single FlashPeriod;
            [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
            public Single FlashDelay;
            [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
            public Int16 NumberOfFlashes;
            [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions), true)]
            public Int16 FlashFlags;
            [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
            public Single FlashLength;
            [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
            public ColorArgb DisabledColor;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(4)]
            public Byte[] EmptyString2;
            [Abide.Guerilla.Tags.FieldAttribute("frame rate", typeof(Single))]
            public Single FrameRate;
            [Abide.Guerilla.Tags.FieldAttribute("sequence index", typeof(Int16))]
            public Int16 SequenceIndex;
            [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Int16))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), true)]
            public Int16 Type;
            [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
            public Int32 Flags;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(16)]
            public Byte[] EmptyString3;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(40)]
            public Byte[] EmptyString4;
            public int Size
            {
                get
                {
                    return 136;
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
            public enum ScalingFlagsOptions
            {
                DontScaleOffset = 1,
                DontScaleSize = 2,
            }
            public enum FlashFlagsOptions
            {
                ReverseDefaultflashingColors = 1,
            }
            public enum TypeOptions
            {
                ShowOnFlashing = 1,
                ShowOnEmpty = 2,
                ShowOnDefault = 4,
                ShowAlways = 8,
            }
            public enum FlagsOptions
            {
                FlashesWhenActive = 1,
            }
        }
        [Abide.Guerilla.Tags.FieldSetAttribute(56, 4)]
        public sealed class GrenadeHudSoundBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
        {
            [Abide.Guerilla.Tags.FieldAttribute("sound^", typeof(TagReference))]
            public TagReference Sound;
            [Abide.Guerilla.Tags.FieldAttribute("latched to", typeof(Int32))]
            [Abide.Guerilla.Tags.OptionsAttribute(typeof(LatchedToOptions), true)]
            public Int32 LatchedTo;
            [Abide.Guerilla.Tags.FieldAttribute("scale", typeof(Single))]
            public Single Scale;
            [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
            [Abide.Guerilla.Tags.PaddingAttribute(32)]
            public Byte[] EmptyString;
            public int Size
            {
                get
                {
                    return 56;
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
            public enum LatchedToOptions
            {
                LowGrenadeCount = 1,
                NoGrenadesLeft = 2,
                ThrowOnNoGrenades = 4,
            }
        }
        public enum AnchorOptions
        {
            TopLeft = 0,
            TopRight = 1,
            BottomLeft = 2,
            BottomRight = 3,
            Center = 4,
            Crosshair = 5,
        }
        public enum ScalingFlagsOptions
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum ScalingFlagsOptions1
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions1
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum ScalingFlagsOptions2
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions2
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum FlagsOptions
        {
            ShowLeadingZeros = 1,
            OnlyShowWhenZoomed = 2,
            DrawATrailingM = 4,
        }
        public enum FlagsOptions1
        {
            UseTextFromStringListInstead = 1,
            OverrideDefaultColor = 2,
            WidthOffsetIsAbsoluteIconWidth = 4,
        }
    }
}
#pragma warning restore CS1591
