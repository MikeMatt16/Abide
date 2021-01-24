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
    /// Represents the generated rasterizer_screen_effect_texcoord_generation_advanced_control_block tag block.
    /// </summary>
    public sealed class RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock"/> class.
        /// </summary>
        public RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock()
        {
            this.Fields.Add(new WordFlagsField("stage 0 flags", "xy scaled by z_far"));
            this.Fields.Add(new WordFlagsField("stage 1 flags", "xy scaled by z_far"));
            this.Fields.Add(new WordFlagsField("stage 2 flags", "xy scaled by z_far"));
            this.Fields.Add(new WordFlagsField("stage 3 flags", "xy scaled by z_far"));
            this.Fields.Add(new RealPlane3dField("stage 0 offset"));
            this.Fields.Add(new RealPlane3dField("stage 1 offset"));
            this.Fields.Add(new RealPlane3dField("stage 2 offset"));
            this.Fields.Add(new RealPlane3dField("stage 3 offset"));
        }
        /// <summary>
        /// Gets and returns the name of the rasterizer_screen_effect_texcoord_generation_advanced_control_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "rasterizer_screen_effect_texcoord_generation_advanced_control_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the rasterizer_screen_effect_texcoord_generation_advanced_control_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "advanced control";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the rasterizer_screen_effect_texcoord_generation_advanced_control_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the rasterizer_screen_effect_texcoord_generation_advanced_control_block tag block.
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
