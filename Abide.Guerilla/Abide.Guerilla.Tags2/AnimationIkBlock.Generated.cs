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
    public class AnimationIkBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("marker#the marker name on the object being attached", typeof(StringId))]
        public StringId Marker;
        [Abide.Guerilla.Tags.FieldAttribute("attach to marker#the marker name object (weapon, vehicle, etc.) the above marker " +
            "is being attached to", typeof(StringId))]
        public StringId AttachToMarker;
    }
}
#pragma warning restore CS1591
