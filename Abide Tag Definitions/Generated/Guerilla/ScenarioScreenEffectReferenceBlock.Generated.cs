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
    /// Represents the generated scenario_screen_effect_reference_block tag block.
    /// </summary>
    public sealed class ScenarioScreenEffectReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioScreenEffectReferenceBlock"/> class.
        /// </summary>
        public ScenarioScreenEffectReferenceBlock()
        {
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new TagReferenceField("Screen Effect", 1701277554));
            this.Fields.Add(new StringIdField("Primary Input:Interpolator"));
            this.Fields.Add(new StringIdField("Secondary Input:Interpolator"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new SkipField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_screen_effect_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_screen_effect_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_screen_effect_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "screen effect reference";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_screen_effect_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_screen_effect_reference_block tag block.
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
