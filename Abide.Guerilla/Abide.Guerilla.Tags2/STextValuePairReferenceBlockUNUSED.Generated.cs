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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(20, 4)]
    public class STextValuePairReferenceBlockUNUSED
    {
        [Abide.Guerilla.Tags.FieldAttribute("value type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ValueTypeOptions), false)]
        public Int16 ValueType;
        [Abide.Guerilla.Tags.FieldAttribute("boolean value", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(BooleanValueOptions), false)]
        public Int16 BooleanValue;
        [Abide.Guerilla.Tags.FieldAttribute("integer value", typeof(Int32))]
        public Int32 IntegerValue;
        [Abide.Guerilla.Tags.FieldAttribute("fp value", typeof(Single))]
        public Single FpValue;
        [Abide.Guerilla.Tags.FieldAttribute("text value string_id", typeof(StringId))]
        public StringId TextValueStringId;
        [Abide.Guerilla.Tags.FieldAttribute("text label string_id", typeof(StringId))]
        public StringId TextLabelStringId;
        public enum ValueTypeOptions
        {
            IntegerNumber = 0,
            FloatingPointNumber = 1,
            Boolean = 2,
            TextString = 3,
        }
        public enum BooleanValueOptions
        {
            False = 0,
            True = 1,
        }
    }
}
#pragma warning restore CS1591
