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
    /// Represents the generated scenario_atmospheric_fog_mixer_block tag block.
    /// </summary>
    public sealed class ScenarioAtmosphericFogMixerBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioAtmosphericFogMixerBlock"/> class.
        /// </summary>
        public ScenarioAtmosphericFogMixerBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new StringIdField("Atmospheric Fog Source:From Scenario Atmospheric Fog Palette"));
            this.Fields.Add(new StringIdField("Interpolator:From Scenario Interpolators"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new SkipField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_atmospheric_fog_mixer_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_atmospheric_fog_mixer_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_atmospheric_fog_mixer_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mixers";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_atmospheric_fog_mixer_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_atmospheric_fog_mixer_block tag block.
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
