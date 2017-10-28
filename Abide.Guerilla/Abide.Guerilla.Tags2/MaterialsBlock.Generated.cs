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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(316, 4)]
    public class MaterialsBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("parent name", typeof(StringId))]
        public StringId ParentName;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("old material type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(OldMaterialTypeOptions), false)]
        public Int16 OldMaterialType;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("general armor", typeof(StringId))]
        public StringId GeneralArmor;
        [Abide.Guerilla.Tags.FieldAttribute("specific armor", typeof(StringId))]
        public StringId SpecificArmor;
        [Abide.Guerilla.Tags.FieldAttribute("physics properties", typeof(MaterialPhysicsPropertiesStructBlock))]
        public MaterialPhysicsPropertiesStructBlock PhysicsProperties;
        [Abide.Guerilla.Tags.FieldAttribute("old material physics", typeof(TagReference))]
        public TagReference OldMaterialPhysics;
        [Abide.Guerilla.Tags.FieldAttribute("breakable surface", typeof(TagReference))]
        public TagReference BreakableSurface;
        [Abide.Guerilla.Tags.FieldAttribute("sweeteners", typeof(MaterialsSweetenersStructBlock))]
        public MaterialsSweetenersStructBlock Sweeteners;
        [Abide.Guerilla.Tags.FieldAttribute("material effects", typeof(TagReference))]
        public TagReference MaterialEffects;
        public enum FlagsOptions
        {
            Flammable = 1,
            Biomass = 2,
        }
        public enum OldMaterialTypeOptions
        {
            Dirt = 0,
            Sand = 1,
            Stone = 2,
            Snow = 3,
            Wood = 4,
            MetalHollow = 5,
            MetalThin = 6,
            MetalThick = 7,
            Rubber = 8,
            Glass = 9,
            ForceField = 10,
            Grunt = 11,
            HunterArmor = 12,
            HunterSkin = 13,
            Elite = 14,
            Jackal = 15,
            JackalEnergyShield = 16,
            EngineerSkin = 17,
            EngineerForceField = 18,
            FloodCombatForm = 19,
            FloodCarrierForm = 20,
            CyborgArmor = 21,
            CyborgEnergyShield = 22,
            HumanArmor = 23,
            HumanSkin = 24,
            Sentinel = 25,
            Monitor = 26,
            Plastic = 27,
            Water = 28,
            Leaves = 29,
            EliteEnergyShield = 30,
            Ice = 31,
            HunterShield = 32,
        }
    }
}
#pragma warning restore CS1591
