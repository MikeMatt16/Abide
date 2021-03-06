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
    /// Represents the generated scenario_cutscene_camera_point_block tag block.
    /// </summary>
    public sealed class ScenarioCutsceneCameraPointBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioCutsceneCameraPointBlock"/> class.
        /// </summary>
        public ScenarioCutsceneCameraPointBlock()
        {
            this.Fields.Add(new WordFlagsField("Flags", "edit as relative"));
            this.Fields.Add(new EnumField("Type", "normal", "ignore target orientation", "dolly", "ignore target updates"));
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new EulerAngles3dField("Orientation"));
            this.Fields.Add(new AngleField(")Unused"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_cutscene_camera_point_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_cutscene_camera_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_cutscene_camera_point_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_cutscene_camera_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_cutscene_camera_point_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_cutscene_camera_point_block tag block.
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
