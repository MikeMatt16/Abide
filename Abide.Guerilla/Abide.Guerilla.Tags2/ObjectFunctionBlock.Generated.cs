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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(36, 4)]
    public class ObjectFunctionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("import name", typeof(StringId))]
        public StringId ImportName;
        [Abide.Guerilla.Tags.FieldAttribute("export name", typeof(StringId))]
        public StringId ExportName;
        [Abide.Guerilla.Tags.FieldAttribute("turn off with#if the specified function is off, so is this function", typeof(StringId))]
        public StringId TurnOffWith;
        [Abide.Guerilla.Tags.FieldAttribute("min value#function must exceed this value (after mapping) to be active 0. means d" +
            "o nothing", typeof(Single))]
        public Single MinValue;
        [Abide.Guerilla.Tags.FieldAttribute("default function", typeof(MappingFunctionBlock))]
        public MappingFunctionBlock DefaultFunction1;
        [Abide.Guerilla.Tags.FieldAttribute("scale by", typeof(StringId))]
        public StringId ScaleBy;
        public enum FlagsOptions
        {
            Invert = 1,
            MappingDoesNotControlsActive = 2,
            AlwaysActive = 4,
            RandomTimeOffset = 8,
        }
    }
}
#pragma warning restore CS1591
