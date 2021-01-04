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
    /// Represents the generated global_hud_multitexture_overlay_effector_definition tag block.
    /// </summary>
    public sealed class GlobalHudMultitextureOverlayEffectorDefinition : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalHudMultitextureOverlayEffectorDefinition"/> class.
        /// </summary>
        public GlobalHudMultitextureOverlayEffectorDefinition()
        {
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new ExplanationField("source/destination", @"These describe the relationship that causes the effect.
* destination type is the type of variable you want to be effected
* destination tells which texture map (or geometry offset) to apply it to
* source says which value to look at when computing the effect"));
            this.Fields.Add(new EnumField("destination type", "tint [0,1]", "horizontal offset", "vertical offset", "fade [0,1]"));
            this.Fields.Add(new EnumField("destination", "geometry offset", "primary map", "secondary map", "tertiary map"));
            this.Fields.Add(new EnumField("source", "player pitch", "player pitch tangent", "player yaw", "weapon rounds (loaded)", "weapon rounds (inventory)", "weapon heat", "explicit (uses low bound)", "weapon zoom level"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("in/out bounds", "When the source is at the lower inbound, the destination ends up the lower outbou" +
                        "nd and vice-versa applies for the upper values."));
            this.Fields.Add(new RealBoundsField("in bounds:source units"));
            this.Fields.Add(new RealBoundsField("out bounds:pixels"));
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new ExplanationField("tint color bounds", "If destination is tint, these values are used instead of the out bounds."));
            this.Fields.Add(new RealRgbColorField("tint color lower bound"));
            this.Fields.Add(new RealRgbColorField("tint color upper bound"));
            this.Fields.Add(new ExplanationField("periodic functions", "If you use a periodic function as the source, this lets you tweak it."));
            this.Fields.Add(new EnumField("periodic function", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("function period:seconds"));
            this.Fields.Add(new RealField("function phase:seconds"));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the global_hud_multitexture_overlay_effector_definition tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_hud_multitexture_overlay_effector_definition";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_hud_multitexture_overlay_effector_definition tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_hud_multitexture_overlay_effector_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_hud_multitexture_overlay_effector_definition tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 30;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_hud_multitexture_overlay_effector_definition tag block.
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
