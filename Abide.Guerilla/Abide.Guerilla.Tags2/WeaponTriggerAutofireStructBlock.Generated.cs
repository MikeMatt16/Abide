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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    public class WeaponTriggerAutofireStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("autofire time", typeof(Single))]
        public Single AutofireTime;
        [Abide.Guerilla.Tags.FieldAttribute("autofire throw", typeof(Single))]
        public Single AutofireThrow;
        [Abide.Guerilla.Tags.FieldAttribute("secondary action", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(SecondaryActionOptions), false)]
        public Int16 SecondaryAction;
        [Abide.Guerilla.Tags.FieldAttribute("primary action", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(PrimaryActionOptions), false)]
        public Int16 PrimaryAction;
        public enum SecondaryActionOptions
        {
            Fire = 0,
            Charge = 1,
            Track = 2,
            FireOther = 3,
        }
        public enum PrimaryActionOptions
        {
            Fire = 0,
            Charge = 1,
            Track = 2,
            FireOther = 3,
        }
    }
}
#pragma warning restore CS1591