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
    /// Represents the generated scenario_structure_lightmap_block tag block.
    /// </summary>
    public sealed class ScenarioStructureLightmapBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioStructureLightmapBlock"/> class.
        /// </summary>
        public ScenarioStructureLightmapBlock()
        {
            this.Fields.Add(new ExplanationField("lightmap options", @"The following fields control the behavior of the lightmapper

RADIANCE ESTIMATE SEARCH DISTANCE UPPER BOUND: the largest distance the code will look for photons. bigger levels need a bigger search radius.  Measured, in world units, 0.0 defaults to 1.0

RADIANCE ESTIMATE SEARCH DISTANCE LOWER BOUND: the smallest distance the code will look for photons. bigger levels need a bigger search radius.  Measured, in world units, 0.0 defaults to 1.0

LUMINELS PER WORLD UNIT: how many lightmap pixels there should be per world unit.  0.0 defaults to 3.0

OUTPUT WHITE REFERENCE: for experimentation - what wattage the lightmapper considers ""white"" to be for output.  0.0 defaults to 1.0

OUTPUT BLACK REFERENCE: for experimentation - what wattage the lightmapper considers ""black"" to be for output.  0.0 defaults to 0.0

OUTPUT SCHLICK PARAMETER: controls the way midtones are mapped.  0.0 defaults to 4.5

DIFFUSE MAP SCALE: controls how diffuse maps are scaled.  0.0 defaults to 1.5

PRT SUN SCALE: 0.0 defaults to 100.0

PRT SKY SCALE: 0.0 defaults to 1.0

PRT INDIRECT SCALE: 0.0 defaults to 1.0

PRT SCALE: you must set this value.

PRT SURFACE LIGHT SCALE: 0.0 defaults to 1.0

PRT SCENARIO LIGHT SCALE: 0.0 defaults to 1.0

LIGHTPROBE INTERPOLATION OVERIDE(speed): overide the default sampling behavior"));
            this.Fields.Add(new RealField("search distance lower bound"));
            this.Fields.Add(new RealField("search distance upper bound"));
            this.Fields.Add(new RealField("luminels per world unit"));
            this.Fields.Add(new RealField("output white reference"));
            this.Fields.Add(new RealField("output black reference"));
            this.Fields.Add(new RealField("output schlick parameter"));
            this.Fields.Add(new RealField("diffuse map scale"));
            this.Fields.Add(new RealField("sun scale"));
            this.Fields.Add(new RealField("sky scale"));
            this.Fields.Add(new RealField("indirect scale"));
            this.Fields.Add(new RealField("prt scale"));
            this.Fields.Add(new RealField("surface light scale"));
            this.Fields.Add(new RealField("scenario light scale"));
            this.Fields.Add(new RealField("lightprobe interpolation overide"));
            this.Fields.Add(new PadField("", 72));
            this.Fields.Add(new BlockField<StructureLightmapGroupBlock>("lightmap groups", 256));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new BlockField<GlobalErrorReportCategoriesBlock>("errors*", 64));
            this.Fields.Add(new PadField("", 104));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_structure_lightmap_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_structure_lightmap_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_structure_lightmap_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_structure_lightmap";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_structure_lightmap_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_structure_lightmap_block tag block.
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
