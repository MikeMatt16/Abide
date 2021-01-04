//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated multiplayer_variant_settings_interface_definition_block tag block.
    /// </summary>
    public sealed class MultiplayerVariantSettingsInterfaceDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplayerVariantSettingsInterfaceDefinitionBlock"/> class.
        /// </summary>
        public MultiplayerVariantSettingsInterfaceDefinitionBlock()
        {
            this.Fields.Add(new TagReferenceField("", 2003265908));
            this.Fields.Add(new TagReferenceField("", 2003265908));
            this.Fields.Add(new TagReferenceField("", 2003265908));
            this.Fields.Add(new BlockField<VariantSettingEditReferenceBlock>("game engine settings", 40));
            this.Fields.Add(new TagReferenceField("default variant strings", 1970170211));
            this.Fields.Add(new BlockField<GDefaultVariantsBlock>("default variants", 100));
            this.Fields.Add(new ExplanationField("create new slayer variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new ExplanationField("create new king of the hill variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new ExplanationField("create new oddball variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new ExplanationField("create new juggernaut variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new ExplanationField("create new capture the flag variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new ExplanationField("create new assault variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new ExplanationField("create new territories variant", ""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
            this.Fields.Add(new StructField<CreateNewVariantStructBlock>(""));
        }
        /// <summary>
        /// Gets and returns the name of the multiplayer_variant_settings_interface_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "multiplayer_variant_settings_interface_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the multiplayer_variant_settings_interface_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "multiplayer_variant_settings_interface_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the multiplayer_variant_settings_interface_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the multiplayer_variant_settings_interface_definition_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
