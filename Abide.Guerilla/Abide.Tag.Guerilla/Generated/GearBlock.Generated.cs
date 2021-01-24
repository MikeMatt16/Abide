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
    /// Represents the generated gear_block tag block.
    /// </summary>
    public sealed class GearBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GearBlock"/> class.
        /// </summary>
        public GearBlock()
        {
            this.Fields.Add(new ExplanationField("loaded torque", ""));
            this.Fields.Add(new StructField<TorqueCurveStructBlock>("loaded torque curve"));
            this.Fields.Add(new ExplanationField("cruising torque", ""));
            this.Fields.Add(new StructField<TorqueCurveStructBlock>("cruising torque curve"));
            this.Fields.Add(new ExplanationField("gearing", ""));
            this.Fields.Add(new RealField("min time to upshift#seconds"));
            this.Fields.Add(new RealField("engine up-shift scale#0-1"));
            this.Fields.Add(new RealField("gear ratio"));
            this.Fields.Add(new RealField("min time to downshift#seconds"));
            this.Fields.Add(new RealField("engine down-shift scale#0-1"));
        }
        /// <summary>
        /// Gets and returns the name of the gear_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "gear_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the gear_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "gear_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the gear_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the gear_block tag block.
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
