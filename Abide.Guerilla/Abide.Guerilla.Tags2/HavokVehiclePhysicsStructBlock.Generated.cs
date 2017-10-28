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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(96, 4)]
    public class HavokVehiclePhysicsStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags*", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Flags), true)]
        public Int32 Flags1;
        [Abide.Guerilla.Tags.FieldAttribute("ground friction# for friction based vehicles only", typeof(Single))]
        public Single GroundFriction;
        [Abide.Guerilla.Tags.FieldAttribute("ground depth# for friction based vehicles only", typeof(Single))]
        public Single GroundDepth;
        [Abide.Guerilla.Tags.FieldAttribute("ground damp factor# for friction based vehicles only", typeof(Single))]
        public Single GroundDampFactor;
        [Abide.Guerilla.Tags.FieldAttribute("ground moving friction# for friction based vehicles only", typeof(Single))]
        public Single GroundMovingFriction;
        [Abide.Guerilla.Tags.FieldAttribute("ground maximum slope 0#degrees 0-90", typeof(Single))]
        public Single GroundMaximumSlope0;
        [Abide.Guerilla.Tags.FieldAttribute("ground maximum slope 1#degrees 0-90.  and greater than slope 0", typeof(Single))]
        public Single GroundMaximumSlope1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(16)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("anti_gravity_bank_lift#lift per WU.", typeof(Single))]
        public Single AntiGravityBankLift;
        [Abide.Guerilla.Tags.FieldAttribute("steering_bank_reaction_scale#how quickly we bank when we steer ", typeof(Single))]
        public Single SteeringBankReactionScale;
        [Abide.Guerilla.Tags.FieldAttribute("gravity scale#value of 0 defaults to 1.  .5 is half gravity", typeof(Single))]
        public Single GravityScale;
        [Abide.Guerilla.Tags.FieldAttribute("radius*#generated from the radius of the hkConvexShape for this vehicle", typeof(Single))]
        public Single Radius;
        [Abide.Guerilla.Tags.FieldAttribute("anti gravity points", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Anti Gravity Point Definition Block", 16, typeof(AntiGravityPointDefinitionBlock))]
        public TagBlock AntiGravityPoints;
        [Abide.Guerilla.Tags.FieldAttribute("friction points", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Friction Point Definition Block", 16, typeof(FrictionPointDefinitionBlock))]
        public TagBlock FrictionPoints;
        [Abide.Guerilla.Tags.FieldAttribute("*shape phantom shape*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Vehicle Phantom Shape Block", 1, typeof(VehiclePhantomShapeBlock))]
        public TagBlock EmptyString1;
        public enum Flags
        {
            Invalid = 1,
        }
    }
}
#pragma warning restore CS1591
