//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated physics_model_node_constraint_edge_block tag block.
    /// </summary>
    public sealed class PhysicsModelNodeConstraintEdgeBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicsModelNodeConstraintEdgeBlock"/> class.
        /// </summary>
        public PhysicsModelNodeConstraintEdgeBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortBlockIndexField("node a*"));
            this.Fields.Add(new ShortBlockIndexField("node b*"));
            this.Fields.Add(new BlockField<PhysicsModelConstraintEdgeConstraintBlock>("constraints*", 64));
            this.Fields.Add(new StringIdField("node a material#if you don\'t fill this out we will pluck the material from the fi" +
                        "rst primitive, of the first rigid body attached to node a"));
            this.Fields.Add(new StringIdField("node b material#if you don\'t fill this out we will pluck the material from the fi" +
                        "rst primitive, of the first rigid body attached to node b, if node b is none we " +
                        "use whatever material a has"));
        }
        /// <summary>
        /// Gets and returns the name of the physics_model_node_constraint_edge_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "physics_model_node_constraint_edge_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the physics_model_node_constraint_edge_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "physics_model_node_constraint_edge_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the physics_model_node_constraint_edge_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4096;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the physics_model_node_constraint_edge_block tag block.
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
