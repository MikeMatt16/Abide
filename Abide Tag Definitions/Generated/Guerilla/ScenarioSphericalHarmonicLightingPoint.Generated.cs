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
    /// Represents the generated scenario_spherical_harmonic_lighting_point tag block.
    /// </summary>
    public sealed class ScenarioSphericalHarmonicLightingPoint : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioSphericalHarmonicLightingPoint"/> class.
        /// </summary>
        public ScenarioSphericalHarmonicLightingPoint()
        {
            this.Fields.Add(new RealPoint3dField("Position"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_spherical_harmonic_lighting_point tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_spherical_harmonic_lighting_point";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_spherical_harmonic_lighting_point tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_spherical_harmonic_lighting_point";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_spherical_harmonic_lighting_point tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32768;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_spherical_harmonic_lighting_point tag block.
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
