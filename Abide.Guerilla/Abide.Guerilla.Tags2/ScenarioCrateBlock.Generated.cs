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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(76, 4)]
    public class ScenarioCrateBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Type", typeof(Int16))]
        public Int16 Type;
        [Abide.Guerilla.Tags.FieldAttribute("Name^", typeof(Int16))]
        public Int16 Name;
        [Abide.Guerilla.Tags.FieldAttribute("Object Data", typeof(ScenarioObjectDatumStructBlock))]
        public ScenarioObjectDatumStructBlock ObjectData;
        [Abide.Guerilla.Tags.FieldAttribute("Permutation Data", typeof(ScenarioObjectPermutationStructBlock))]
        public ScenarioObjectPermutationStructBlock PermutationData;
    }
}
#pragma warning restore CS1591
