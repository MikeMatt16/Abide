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
    public class AiSceneRoleBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("group", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(GroupOptions), false)]
        public Int16 Group;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("role variants", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Ai Scene Role Variants Block", 10, typeof(AiSceneRoleVariantsBlock))]
        public TagBlock RoleVariants;
        public enum GroupOptions
        {
            Group1 = 0,
            Group2 = 1,
            Group3 = 2,
        }
    }
}
#pragma warning restore CS1591
