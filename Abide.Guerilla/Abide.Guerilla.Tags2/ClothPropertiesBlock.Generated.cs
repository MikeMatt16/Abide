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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(48, 4)]
    public class ClothPropertiesBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Integration type*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(IntegrationType), false)]
        public Int16 IntegrationType1;
        [Abide.Guerilla.Tags.FieldAttribute("Number iterations#[1-8] sug 1", typeof(Int16))]
        public Int16 NumberIterations;
        [Abide.Guerilla.Tags.FieldAttribute("weight#[-10.0 - 10.0] sug 1.0", typeof(Single))]
        public Single Weight;
        [Abide.Guerilla.Tags.FieldAttribute("drag#[0.0 - 0.5] sug 0.07", typeof(Single))]
        public Single Drag;
        [Abide.Guerilla.Tags.FieldAttribute("wind_scale#[0.0 - 3.0] sug 1.0", typeof(Single))]
        public Single WindScale;
        [Abide.Guerilla.Tags.FieldAttribute("wind_flappiness_scale#[0.0 - 1.0] sug 0.75", typeof(Single))]
        public Single WindFlappinessScale;
        [Abide.Guerilla.Tags.FieldAttribute("longest_rod#[1.0 - 10.0] sug 3.5", typeof(Single))]
        public Single LongestRod;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(24)]
        public Byte[] EmptyString;
        public enum IntegrationType
        {
            Verlet = 0,
        }
    }
}
#pragma warning restore CS1591
