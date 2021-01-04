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
    /// Represents the generated ragdoll_constraints_block tag block.
    /// </summary>
    public sealed class RagdollConstraintsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RagdollConstraintsBlock"/> class.
        /// </summary>
        public RagdollConstraintsBlock()
        {
            this.Fields.Add(new StructField<ConstraintBodiesStructBlock>("constraint bodies*"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("min twist*"));
            this.Fields.Add(new RealField("max twist*"));
            this.Fields.Add(new RealField("min cone*"));
            this.Fields.Add(new RealField("max cone*"));
            this.Fields.Add(new RealField("min plane*"));
            this.Fields.Add(new RealField("max plane*"));
            this.Fields.Add(new RealField("max friciton torque*"));
        }
        /// <summary>
        /// Gets and returns the name of the ragdoll_constraints_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ragdoll_constraints_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ragdoll_constraints_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ragdoll_constraints_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ragdoll_constraints_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ragdoll_constraints_block tag block.
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
