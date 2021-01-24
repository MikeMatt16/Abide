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
    /// Represents the generated global_shader_parameter_block tag block.
    /// </summary>
    public sealed class GlobalShaderParameterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalShaderParameterBlock"/> class.
        /// </summary>
        public GlobalShaderParameterBlock()
        {
            this.Fields.Add(new StringIdField("Name^"));
            this.Fields.Add(new EnumField("Type", "Bitmap", "Value", "Color", "Switch"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("Bitmap", 1651078253));
            this.Fields.Add(new RealField("Const Value"));
            this.Fields.Add(new RealRgbColorField("Const Color"));
            this.Fields.Add(new BlockField<ShaderAnimationPropertyBlock>("Animation Properties", 14));
        }
        /// <summary>
        /// Gets and returns the name of the global_shader_parameter_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_shader_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_shader_parameter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "parameter";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_shader_parameter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_shader_parameter_block tag block.
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
