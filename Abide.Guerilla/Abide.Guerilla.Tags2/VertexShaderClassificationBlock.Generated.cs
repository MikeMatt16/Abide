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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(44, 4)]
    public class VertexShaderClassificationBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("compiled shader", typeof(Byte[]))]
        public Byte[] CompiledShader;
        [Abide.Guerilla.Tags.FieldAttribute("code", typeof(Byte[]))]
        public Byte[] Code;
    }
}
#pragma warning restore CS1591
