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
    /// Represents the generated light_volume_aspect_block tag block.
    /// </summary>
    public sealed class LightVolumeAspectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightVolumeAspectBlock"/> class.
        /// </summary>
        public LightVolumeAspectBlock()
        {
            this.Fields.Add(new ExplanationField("SCALE FACTORS", @"These function control the screenspace aspect ratio of each sprite relative to the projected forward axis. Note that there is no range-input to these functions, because it would not make sense to stretch sprites when the light volume is facing directly towards or away from the camera (which way would we stretch them?)"));
            this.Fields.Add(new ExplanationField("ALONG-AXIS SCALE", "Values higher than 1 along the axis will cause sprites to elongate and overlap mo" +
                        "re regardless of the orientation of the light volume, whereas values lower than " +
                        "1 will cause sprite separation."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("along axis"));
            this.Fields.Add(new ExplanationField("AWAY-FROM-AXIS SCALE", "Values higher than 1 away from the axis will cause the light volume to appear thi" +
                        "cker."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("away from axis"));
            this.Fields.Add(new ExplanationField("PARALLEL SCALE", @"When the light volume is viewed directly towards (parallel) or away from the camera, the scale factors above are interpolated towards this constant value. The threshold angle controls when the light volume is considered to be 100% parallel for these computations. The exponent controls how quickly the transition from using the perpendicular scale factors to using the parallel scale factor happens, e.g.:

* exponent=0.0 -> perpendicular scale factors will always be used unless below threshold angle
* exponent=0.1 -> transition quickly as viewing angle becomes perpendicular
* exponent=1.0 -> transition smoothly between perpendicular and parallel
* exponent=9.0 -> transition quickly as viewing angle becomes parallel"));
            this.Fields.Add(new RealField("parallel scale"));
            this.Fields.Add(new AngleField("parallel threshold angle:degrees"));
            this.Fields.Add(new RealField("parallel exponent"));
        }
        /// <summary>
        /// Gets and returns the name of the light_volume_aspect_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "light_volume_aspect_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the light_volume_aspect_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "aspect";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the light_volume_aspect_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the light_volume_aspect_block tag block.
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
