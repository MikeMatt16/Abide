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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(148, 4)]
    public class RagdollConstraintsBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("constraint bodies*", typeof(ConstraintBodiesStructBlock))]
        public ConstraintBodiesStructBlock ConstraintBodies;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("min twist*", typeof(Single))]
        public Single MinTwist;
        [Abide.Guerilla.Tags.FieldAttribute("max twist*", typeof(Single))]
        public Single MaxTwist;
        [Abide.Guerilla.Tags.FieldAttribute("min cone*", typeof(Single))]
        public Single MinCone;
        [Abide.Guerilla.Tags.FieldAttribute("max cone*", typeof(Single))]
        public Single MaxCone;
        [Abide.Guerilla.Tags.FieldAttribute("min plane*", typeof(Single))]
        public Single MinPlane;
        [Abide.Guerilla.Tags.FieldAttribute("max plane*", typeof(Single))]
        public Single MaxPlane;
        [Abide.Guerilla.Tags.FieldAttribute("max friciton torque*", typeof(Single))]
        public Single MaxFricitonTorque;
    }
}
#pragma warning restore CS1591