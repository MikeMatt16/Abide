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
    public class CharacterSearchBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Search flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(SearchFlagsOptions), true)]
        public Int32 SearchFlags;
        public enum SearchFlagsOptions
        {
            CrouchOnInvestigate = 1,
            WalkOnPursuit = 2,
        }
    }
}
#pragma warning restore CS1591