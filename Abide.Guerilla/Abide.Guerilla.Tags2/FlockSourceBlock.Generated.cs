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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(28, 4)]
    public class FlockSourceBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("position", typeof(Vector3))]
        public Vector3 Position;
        [Abide.Guerilla.Tags.FieldAttribute("starting yaw, pitch:degrees", typeof(Vector2))]
        public Vector2 StartingYawPitch;
        [Abide.Guerilla.Tags.FieldAttribute("radius", typeof(Single))]
        public Single Radius;
        [Abide.Guerilla.Tags.FieldAttribute("weight#probability of producing at this source", typeof(Single))]
        public Single Weight;
    }
}
#pragma warning restore CS1591
