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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(80, 4)]
    public class StructureBspSoundEnvironmentPaletteBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(String32))]
        public String32 Name;
        [Abide.Guerilla.Tags.FieldAttribute("Sound Environment", typeof(TagReference))]
        public TagReference SoundEnvironment;
        [Abide.Guerilla.Tags.FieldAttribute("Cutoff Distance", typeof(Single))]
        public Single CutoffDistance;
        [Abide.Guerilla.Tags.FieldAttribute("Interpolation Speed:1/sec", typeof(Single))]
        public Single InterpolationSpeed;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(24)]
        public Byte[] EmptyString;
    }
}
#pragma warning restore CS1591
