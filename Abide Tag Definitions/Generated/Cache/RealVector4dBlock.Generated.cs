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
    /// Represents the generated real_vector4d_block tag block.
    /// </summary>
    public sealed class RealVector4dBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector4dBlock"/> class.
        /// </summary>
        public RealVector4dBlock()
        {
            this.Fields.Add(new RealVector3dField("vector3"));
            this.Fields.Add(new RealField("w"));
        }
        /// <summary>
        /// Gets and returns the name of the real_vector4d_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "real_vector4d_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the real_vector4d_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "real_vector4d_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the real_vector4d_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the real_vector4d_block tag block.
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
