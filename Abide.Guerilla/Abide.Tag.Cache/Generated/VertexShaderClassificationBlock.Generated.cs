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
    /// Represents the generated vertex_shader_classification_block tag block.
    /// </summary>
    public sealed class VertexShaderClassificationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VertexShaderClassificationBlock"/> class.
        /// </summary>
        public VertexShaderClassificationBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new DataField("compiled shader", 2, 4));
            this.Fields.Add(new DataField("code", 1, 4));
            this.Fields.Add(new PadField("", 8));
        }
        /// <summary>
        /// Gets and returns the name of the vertex_shader_classification_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "vertex_shader_classification_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the vertex_shader_classification_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "classification";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the vertex_shader_classification_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 12;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the vertex_shader_classification_block tag block.
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
