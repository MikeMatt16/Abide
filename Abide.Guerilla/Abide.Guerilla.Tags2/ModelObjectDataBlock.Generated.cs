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
    public class ModelObjectDataBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("type*", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Type), false)]
        public Int16 Type1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("offset*", typeof(Vector3))]
        public Vector3 Offset;
        [Abide.Guerilla.Tags.FieldAttribute("radius*", typeof(Single))]
        public Single Radius;
        public enum Type
        {
            NotSet = 0,
            UserDefined = 1,
            AutoGenerated = 2,
        }
    }
}
#pragma warning restore CS1591