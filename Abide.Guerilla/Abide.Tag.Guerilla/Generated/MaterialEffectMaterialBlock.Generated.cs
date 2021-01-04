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
    /// Represents the generated material_effect_material_block tag block.
    /// </summary>
    public sealed class MaterialEffectMaterialBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialEffectMaterialBlock"/> class.
        /// </summary>
        public MaterialEffectMaterialBlock()
        {
            this.Fields.Add(new TagReferenceField("tag (effect or sound)", -3));
            this.Fields.Add(new TagReferenceField("secondary tag (effect or sound)", -3));
            this.Fields.Add(new StringIdField("material name^"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new CharEnumField("sweetener mode", "sweetener default", "sweetener enabled", "sweetener disabled"));
            this.Fields.Add(new PadField("", 1));
        }
        /// <summary>
        /// Gets and returns the name of the material_effect_material_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "material_effect_material_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the material_effect_material_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material_effect_material_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the material_effect_material_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 500;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the material_effect_material_block tag block.
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
