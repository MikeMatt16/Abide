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
    public class CharacterPhysicsFlyingStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("bank angle:degrees#angle at which we bank left/right when sidestepping or turning" +
            " while moving forwards", typeof(Single))]
        public Single BankAngle;
        [Abide.Guerilla.Tags.FieldAttribute("bank apply time:seconds#time it takes us to apply a bank", typeof(Single))]
        public Single BankApplyTime;
        [Abide.Guerilla.Tags.FieldAttribute("bank decay time:seconds#time it takes us to recover from a bank", typeof(Single))]
        public Single BankDecayTime;
        [Abide.Guerilla.Tags.FieldAttribute("pitch ratio#amount that we pitch up/down when moving up or down", typeof(Single))]
        public Single PitchRatio;
        [Abide.Guerilla.Tags.FieldAttribute("max velocity:world units per second#max velocity when not crouching", typeof(Single))]
        public Single MaxVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("max sidestep velocity:world units per second#max sideways or up/down velocity whe" +
            "n not crouching", typeof(Single))]
        public Single MaxSidestepVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("acceleration:world units per second squared", typeof(Single))]
        public Single Acceleration;
        [Abide.Guerilla.Tags.FieldAttribute("deceleration:world units per second squared", typeof(Single))]
        public Single Deceleration;
        [Abide.Guerilla.Tags.FieldAttribute("angular velocity maximum:degrees per second#turn rate", typeof(Single))]
        public Single AngularVelocityMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("angular acceleration maximum:degrees per second squared#turn acceleration rate", typeof(Single))]
        public Single AngularAccelerationMaximum;
        [Abide.Guerilla.Tags.FieldAttribute("crouch velocity modifier:[0,1]#how much slower we fly if crouching (zero = same s" +
            "peed)", typeof(Single))]
        public Single CrouchVelocityModifier;
    }
}
#pragma warning restore CS1591
