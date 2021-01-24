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
    /// Represents the generated physics_model_constraint_edge_constraint_block tag block.
    /// </summary>
    public sealed class PhysicsModelConstraintEdgeConstraintBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicsModelConstraintEdgeConstraintBlock"/> class.
        /// </summary>
        public PhysicsModelConstraintEdgeConstraintBlock()
        {
            this.Fields.Add(new EnumField("type*", "hinge", "limited hinge", "ragdoll", "stiff spring", "ball and socket", "prismatic"));
            this.Fields.Add(new ShortBlockIndexField("index*"));
            this.Fields.Add(new LongFlagsField("flags", "is rigid#this constraint makes the edge rigid until it is loosened by damage", "disable effects#this constraint will not generate impact effects"));
            this.Fields.Add(new RealField("friction#0 is the default (takes what it was set in max) anything else overrides " +
                        "that value"));
        }
        /// <summary>
        /// Gets and returns the name of the physics_model_constraint_edge_constraint_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "physics_model_constraint_edge_constraint_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the physics_model_constraint_edge_constraint_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "physics_model_constraint_edge_constraint_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the physics_model_constraint_edge_constraint_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the physics_model_constraint_edge_constraint_block tag block.
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
