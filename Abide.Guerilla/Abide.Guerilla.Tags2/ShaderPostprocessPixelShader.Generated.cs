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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(84, 4)]
    public class ShaderPostprocessPixelShader
    {
        [Abide.Guerilla.Tags.FieldAttribute("pixel shader handle (runtime)", typeof(Int32))]
        public Int32 PixelShaderHandleRuntime;
        [Abide.Guerilla.Tags.FieldAttribute("pixel shader handle (runtime)", typeof(Int32))]
        public Int32 PixelShaderHandleRuntime1;
        [Abide.Guerilla.Tags.FieldAttribute("pixel shader handle (runtime)", typeof(Int32))]
        public Int32 PixelShaderHandleRuntime2;
        [Abide.Guerilla.Tags.FieldAttribute("constant register defaults", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Shader Postprocess Pixel Shader Constant Defaults", 32, typeof(ShaderPostprocessPixelShaderConstantDefaults))]
        public TagBlock ConstantRegisterDefaults;
        [Abide.Guerilla.Tags.FieldAttribute("compiled shader", typeof(Byte[]))]
        public Byte[] CompiledShader;
        [Abide.Guerilla.Tags.FieldAttribute("compiled shader", typeof(Byte[]))]
        public Byte[] CompiledShader1;
        [Abide.Guerilla.Tags.FieldAttribute("compiled shader", typeof(Byte[]))]
        public Byte[] CompiledShader2;
    }
}
#pragma warning restore CS1591
