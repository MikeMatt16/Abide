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
    /// Represents the generated structure_lightmap_lighting_environment_block tag block.
    /// </summary>
    public sealed class StructureLightmapLightingEnvironmentBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureLightmapLightingEnvironmentBlock"/> class.
        /// </summary>
        public StructureLightmapLightingEnvironmentBlock()
        {
            this.Fields.Add(new RealPoint3dField("sample_point*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("red coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("green coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealField("blue coefficient*"));
            this.Fields.Add(new RealVector3dField("mean incoming light direction"));
            this.Fields.Add(new RealPoint3dField("incoming light intensity"));
            this.Fields.Add(new LongIntegerField("specular bitmap index"));
            this.Fields.Add(new RealVector3dField("rotation axis"));
            this.Fields.Add(new RealField("rotation speed"));
            this.Fields.Add(new RealVector3dField("bump direction"));
            this.Fields.Add(new RealRgbColorField("color tint"));
            this.Fields.Add(new EnumField("procedural overide", "no overide", "CIE clear sky", "CIE partly cloudy", "CIE cloudy", "directional light", "cone light", "sphere light", "hemisphere light"));
            this.Fields.Add(new WordFlagsField("flags", "leave me alone please"));
            this.Fields.Add(new RealVector3dField("procedural param0"));
            this.Fields.Add(new RealVector3dField("procedural param1.xyz"));
            this.Fields.Add(new RealField("procedural param1.w"));
        }
        /// <summary>
        /// Gets and returns the name of the structure_lightmap_lighting_environment_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_lightmap_lighting_environment_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_lightmap_lighting_environment_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_lightmap_lighting_environment_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_lightmap_lighting_environment_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_lightmap_lighting_environment_block tag block.
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
