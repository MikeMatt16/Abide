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
    public class CharacterLookBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("maximum aiming deviation:degrees#how far we can turn our weapon", typeof(Vector2))]
        public Vector2 MaximumAimingDeviation;
        [Abide.Guerilla.Tags.FieldAttribute("maximum looking deviation:degrees#how far we can turn our head", typeof(Vector2))]
        public Vector2 MaximumLookingDeviation;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(16)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("noncombat look delta L:degrees#how far we can turn our head left away from our ai" +
            "ming vector when not in combat", typeof(Single))]
        public Single NoncombatLookDeltaL;
        [Abide.Guerilla.Tags.FieldAttribute("noncombat look delta R:degrees#how far we can turn our head right away from our a" +
            "iming vector when not in combat", typeof(Single))]
        public Single NoncombatLookDeltaR;
        [Abide.Guerilla.Tags.FieldAttribute("combat look delta L:degrees#how far we can turn our head left away from our aimin" +
            "g vector when in combat", typeof(Single))]
        public Single CombatLookDeltaL;
        [Abide.Guerilla.Tags.FieldAttribute("combat look delta R:degrees#how far we can turn our head right away from our aimi" +
            "ng vector when in combat", typeof(Single))]
        public Single CombatLookDeltaR;
    }
}
#pragma warning restore CS1591