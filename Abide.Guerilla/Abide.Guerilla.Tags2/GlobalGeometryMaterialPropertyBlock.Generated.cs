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
    public class GlobalGeometryMaterialPropertyBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Type*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Type), false)]
        public Int16 Type1;
        [Abide.Guerilla.Tags.FieldAttribute("Int Value*", typeof(Int16))]
        public Int16 IntValue;
        [Abide.Guerilla.Tags.FieldAttribute("Real Value*", typeof(Single))]
        public Single RealValue;
        public enum Type
        {
            LightmapResolution = 0,
            LightmapPower = 1,
            LightmapHalfLife = 2,
            LightmapDiffuseScale = 3,
        }
    }
}
#pragma warning restore CS1591