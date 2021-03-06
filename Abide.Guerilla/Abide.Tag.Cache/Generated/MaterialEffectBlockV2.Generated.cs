//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated material_effect_block_v2 tag block.
    /// </summary>
    public sealed class MaterialEffectBlockV2 : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialEffectBlockV2"/> class.
        /// </summary>
        public MaterialEffectBlockV2()
        {
            this.Fields.Add(new BlockField<OldMaterialEffectMaterialBlock>("old materials (DO NOT USE)", 33));
            this.Fields.Add(new BlockField<MaterialEffectMaterialBlock>("sounds", 500));
            this.Fields.Add(new BlockField<MaterialEffectMaterialBlock>("effects", 500));
        }
        /// <summary>
        /// Gets and returns the name of the material_effect_block_v2 tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "material_effect_block_v2";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the material_effect_block_v2 tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material_effect_block_v2";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the material_effect_block_v2 tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 21;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the material_effect_block_v2 tag block.
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
