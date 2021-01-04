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
    /// Represents the generated patchy_fog_block tag block.
    /// </summary>
    public sealed class PatchyFogBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchyFogBlock"/> class.
        /// </summary>
        public PatchyFogBlock()
        {
            this.Fields.Add(new ExplanationField("PATCHY FOG", "Use the separate_layer_depths flag carefully, it\'s expensive!"));
            this.Fields.Add(new WordFlagsField("flags", "separate layer depths", "sort behind transparents"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("MOVEMENT MODIFIERS", ""));
            this.Fields.Add(new RealFractionField("rotation multiplier:[0,1]"));
            this.Fields.Add(new RealFractionField("strafing multiplier:[0,1]"));
            this.Fields.Add(new RealFractionField("zoom multiplier:[0,1]"));
            this.Fields.Add(new ExplanationField("NOISE MAP", ""));
            this.Fields.Add(new RealField("noise map scale#0 defaults to 1"));
            this.Fields.Add(new TagReferenceField("noise map", 1651078253));
            this.Fields.Add(new RealField("noise vertical scale forward#0 defaults to 1"));
            this.Fields.Add(new RealField("noise vertical scale up#0 defaults to 1"));
            this.Fields.Add(new RealField("noise opacity scale up#0 defaults to 1"));
            this.Fields.Add(new ExplanationField("ANIMATION", ""));
            this.Fields.Add(new RealField("animation period:seconds"));
            this.Fields.Add(new RealBoundsField("wind velocity:world units per second"));
            this.Fields.Add(new RealBoundsField("wind period:seconds#0 defaults to 1"));
            this.Fields.Add(new RealFractionField("wind acceleration weight:[0,1]"));
            this.Fields.Add(new RealFractionField("wind perpendicular weight:[0,1]"));
            this.Fields.Add(new RealField("wind constant velocity x:world units per second"));
            this.Fields.Add(new RealField("wind constant velocity y:world units per second"));
            this.Fields.Add(new RealField("wind constant velocity z:world units per second"));
        }
        /// <summary>
        /// Gets and returns the name of the patchy_fog_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "patchy_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the patchy_fog_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "patchy_fog";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the patchy_fog_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the patchy_fog_block tag block.
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
