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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(4, 4)]
    public class LeavesBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Flags*", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Flags), true)]
        public Byte Flags1;
        [Abide.Guerilla.Tags.FieldAttribute("BSP 2D Reference Count*", typeof(Byte))]
        public Byte Bsp2dReferenceCount;
        [Abide.Guerilla.Tags.FieldAttribute("First BSP 2D Reference*", typeof(Int16))]
        public Int16 FirstBsp2dReference;
        public enum Flags
        {
            ContainsDoublesidedSurfaces = 1,
        }
    }
}
#pragma warning restore CS1591
