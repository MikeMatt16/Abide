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
    /// Represents the generated liquid_core_block tag block.
    /// </summary>
    public sealed class LiquidCoreBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidCoreBlock"/> class.
        /// </summary>
        public LiquidCoreBlock()
        {
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new ShortIntegerField("bitmap index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("THICKNESS", "In world units."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("thickness"));
            this.Fields.Add(new ExplanationField("COLOR", ""));
            this.Fields.Add(new StructField<ColorFunctionStructBlock>("color"));
            this.Fields.Add(new ExplanationField("BRIGHTNESS/TIME", "Periodic function based on time."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("brightness-time"));
            this.Fields.Add(new ExplanationField("BRIGHTNESS/FACING", "Brightness when facing perpendicular versus parallel."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("brightness-facing"));
            this.Fields.Add(new ExplanationField("ALONG-AXIS SCALE", "Scale along-axis. Default should be 1."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("along-axis scale"));
        }
        /// <summary>
        /// Gets and returns the name of the liquid_core_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "liquid_core_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the liquid_core_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "core";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the liquid_core_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the liquid_core_block tag block.
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
