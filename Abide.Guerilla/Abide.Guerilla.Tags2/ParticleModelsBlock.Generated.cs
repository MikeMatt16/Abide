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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
    public class ParticleModelsBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("model name*", typeof(StringId))]
        public StringId ModelName;
        [Abide.Guerilla.Tags.FieldAttribute("index start*", typeof(Int16))]
        public Int16 IndexStart;
        [Abide.Guerilla.Tags.FieldAttribute("index count*", typeof(Int16))]
        public Int16 IndexCount;
    }
}
#pragma warning restore CS1591