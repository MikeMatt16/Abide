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
    /// Represents the generated contrail_block tag block.
    /// </summary>
    public sealed class ContrailBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContrailBlock"/> class.
        /// </summary>
        public ContrailBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "first point unfaded", "last point unfaded", "points start pinned to media", "points start pinned to ground", "points always pinned to media", "points always pinned to ground", "edge effect fades slowly", "dont\'t inherit object change color"));
            this.Fields.Add(new WordFlagsField("scale flags#these flags determine which fields are scaled by the contrail density" +
                        "", "point generation rate", "point velocity", "point velocity delta", "point velocity cone angle", "inherited velocity fraction", "sequence animation rate", "texture scale u", "texture scale v", "texture animation u", "texture animation v"));
            this.Fields.Add(new ExplanationField("point creation", ""));
            this.Fields.Add(new RealField("point generation rate:points per second#this many points are generated per second" +
                        ""));
            this.Fields.Add(new RealBoundsField("point velocity:world units per second#velocity added to each point\'s initial velo" +
                        "city"));
            this.Fields.Add(new AngleField("point velocity cone angle:degrees#initial velocity is inside the cone defined by " +
                        "the marker\'s forward vector and this angle"));
            this.Fields.Add(new RealFractionField("inherited velocity fraction#fraction of parent object\'s velocity that is inherite" +
                        "d by contrail points."));
            this.Fields.Add(new ExplanationField("rendering", ""));
            this.Fields.Add(new EnumField("render type#this specifies how the contrail is oriented in space", "vertical orientation", "horizontal orientation", "media mapped", "ground mapped", "viewer facing", "double-marker linked"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("texture repeats u#texture repeats per contrail segment"));
            this.Fields.Add(new RealField("texture repeats v#texture repeats across contrail width"));
            this.Fields.Add(new RealField("texture animation u:repeats per second#the texture along the contrail is animated" +
                        " by this value"));
            this.Fields.Add(new RealField("texture animation v:repeats per second#the texture across the contrail is animate" +
                        "d by this value"));
            this.Fields.Add(new RealField("animation rate:frames per second"));
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
            this.Fields.Add(new ShortIntegerField("first sequence index"));
            this.Fields.Add(new ShortIntegerField("sequence count"));
            this.Fields.Add(new PadField("", 40));
            this.Fields.Add(new WordFlagsField("shader flags", "sort bias", "nonlinear tint", "don\'t overdraw fp weapon"));
            this.Fields.Add(new EnumField("framebuffer blend function", "alpha blend", "multiply", "double multiply", "add", "subtract", "component min", "component max", "alpha-multiply add", "constant color blend", "inverse constant color blend", "none"));
            this.Fields.Add(new EnumField("framebuffer fade mode", "none", "fade when perpendicular", "fade when parallel"));
            this.Fields.Add(new WordFlagsField("map flags", "unfiltered"));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new ExplanationField("Secondary Map", "Optional multitextured second map"));
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
            this.Fields.Add(new EnumField("anchor", "with primary", "with screen space", "zsprite"));
            this.Fields.Add(new WordFlagsField("flags", "unfiltered"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("u-animation function", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new RealField("u-animation period:seconds#0 defaults to 1"));
            this.Fields.Add(new RealField("u-animation phase"));
            this.Fields.Add(new RealField("u-animation scale:repeats#0 defaults to 1"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("v-animation function", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new RealField("v-animation period:seconds#0 defaults to 1"));
            this.Fields.Add(new RealField("v-animation phase"));
            this.Fields.Add(new RealField("v-animation scale:repeats#0 defaults to 1"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("rotation-animation function", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new RealField("rotation-animation period:seconds#0 defaults to 1"));
            this.Fields.Add(new RealField("rotation-animation phase"));
            this.Fields.Add(new RealField("rotation-animation scale:degrees#0 defaults to 360"));
            this.Fields.Add(new RealPoint2dField("rotation-animation center"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("zsprite radius scale"));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new BlockField<ContrailPointStatesBlock>("point states", 16));
        }
        /// <summary>
        /// Gets and returns the name of the contrail_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "contrail_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the contrail_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "contrail";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the contrail_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the contrail_block tag block.
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
