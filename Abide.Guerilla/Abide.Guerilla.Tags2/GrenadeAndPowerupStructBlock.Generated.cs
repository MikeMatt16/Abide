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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
    public class GrenadeAndPowerupStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("grenades", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Grenade Block", 20, typeof(GrenadeBlock))]
        public TagBlock Grenades;
        [Abide.Guerilla.Tags.FieldAttribute("powerups", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Powerup Block", 20, typeof(PowerupBlock))]
        public TagBlock Powerups;
    }
}
#pragma warning restore CS1591
