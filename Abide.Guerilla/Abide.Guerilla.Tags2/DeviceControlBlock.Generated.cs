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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(60, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("device_control", "ctrl", "devi", typeof(DeviceControlBlock))]
    public class DeviceControlBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), false)]
        public Int16 Type;
        [Abide.Guerilla.Tags.FieldAttribute("triggers when", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(TriggersWhenOptions), false)]
        public Int16 TriggersWhen;
        [Abide.Guerilla.Tags.FieldAttribute("call value:[0,1]", typeof(Single))]
        public Single CallValue;
        [Abide.Guerilla.Tags.FieldAttribute("action string", typeof(StringId))]
        public StringId ActionString;
        [Abide.Guerilla.Tags.FieldAttribute("on", typeof(TagReference))]
        public TagReference On;
        [Abide.Guerilla.Tags.FieldAttribute("off", typeof(TagReference))]
        public TagReference Off;
        [Abide.Guerilla.Tags.FieldAttribute("deny", typeof(TagReference))]
        public TagReference Deny;
        public enum TypeOptions
        {
            ToggleSwitch = 0,
            OnButton = 1,
            OffButton = 2,
            CallButton = 3,
        }
        public enum TriggersWhenOptions
        {
            TouchedByPlayer = 0,
            Destroyed = 1,
        }
    }
}
#pragma warning restore CS1591
