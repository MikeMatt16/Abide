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
    /// Represents the generated inertial_matrix_block tag block.
    /// </summary>
    public sealed class InertialMatrixBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InertialMatrixBlock"/> class.
        /// </summary>
        public InertialMatrixBlock()
        {
            this.Fields.Add(new RealVector3dField("yy+zz    -xy     -zx"));
            this.Fields.Add(new RealVector3dField(" -xy    zz+xx    -yz"));
            this.Fields.Add(new RealVector3dField(" -zx     -yz    xx+yy"));
        }
        /// <summary>
        /// Gets and returns the name of the inertial_matrix_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "inertial_matrix_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the inertial_matrix_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "inertial_matrix_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the inertial_matrix_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the inertial_matrix_block tag block.
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
