//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated lighting_variables_block tag block.
    /// </summary>
    public sealed class LightingVariablesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightingVariablesBlock"/> class.
        /// </summary>
        public LightingVariablesBlock()
        {
            this.Fields.Add(new LongFlagsField("object affected", "all", "biped", "vehicle", "weapon", "equipment", "garbage", "projectile", "scenery", "machine", "control", "light fixture", "sound scenery", "crate", "creature"));
            this.Fields.Add(new ExplanationField("Global lightmap sample", ""));
            this.Fields.Add(new RealField("Lightmap brightness offset"));
            this.Fields.Add(new StructField<PrimaryLightStructBlock>("primary light"));
            this.Fields.Add(new StructField<SecondaryLightStructBlock>("secondary light"));
            this.Fields.Add(new StructField<AmbientLightStructBlock>("ambient light"));
            this.Fields.Add(new StructField<LightmapShadowsStructBlock>("lightmap shadows"));
        }
        /// <summary>
        /// Gets and returns the name of the lighting_variables_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "lighting_variables_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lighting_variables_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "lighting_variables_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lighting_variables_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 13;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lighting_variables_block tag block.
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
