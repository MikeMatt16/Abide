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

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(220, 4)]
    public class GlobalHudMultitextureOverlayEffectorDefinition
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
}
#pragma warning restore CS1591
