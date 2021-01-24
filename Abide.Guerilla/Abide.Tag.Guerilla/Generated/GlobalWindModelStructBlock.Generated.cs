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
    /// Represents the generated global_wind_model_struct_block tag block.
    /// </summary>
    public sealed class GlobalWindModelStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalWindModelStructBlock"/> class.
        /// </summary>
        public GlobalWindModelStructBlock()
        {
            this.Fields.Add(new RealField("wind tiling scale"));
            this.Fields.Add(new RealVector3dField("wind primary heading/pitch/strength"));
            this.Fields.Add(new RealField("primary rate of change"));
            this.Fields.Add(new RealField("primary min strength"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealVector3dField("wind gusting heading/pitch/strength"));
            this.Fields.Add(new RealField("gust diretional rate of change"));
            this.Fields.Add(new RealField("gust strength rate of change"));
            this.Fields.Add(new RealField("gust cone angle"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealField("turbulance rate of change"));
            this.Fields.Add(new RealVector3dField("turbulence_scale x, y, z"));
            this.Fields.Add(new RealField("gravity constant"));
            this.Fields.Add(new BlockField<GloalWindPrimitivesBlock>("wind_pirmitives", 128));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the global_wind_model_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_wind_model_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_wind_model_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_wind_model_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_wind_model_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_wind_model_struct_block tag block.
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
