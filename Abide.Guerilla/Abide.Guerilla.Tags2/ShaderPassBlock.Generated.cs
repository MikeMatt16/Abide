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
    [Abide.Guerilla.Tags.TagGroupAttribute("shader_pass", "spas", "����", typeof(ShaderPassBlock))]
    public class ShaderPassBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Documentation", typeof(Byte[]))]
        public Byte[] Documentation;
        [Abide.Guerilla.Tags.FieldAttribute("Parameters", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Parameter", 64, typeof(ShaderPassParameterBlock))]
        public TagBlock Parameters;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("Implementations", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Implementation", 32, typeof(ShaderPassImplementationBlock))]
        public TagBlock Implementations;
        [Abide.Guerilla.Tags.FieldAttribute("Postprocess Definition*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Shader Pass Postprocess Definition New Block", 1, typeof(ShaderPassPostprocessDefinitionNewBlock))]
        public TagBlock PostprocessDefinition;
    }
}
#pragma warning restore CS1591