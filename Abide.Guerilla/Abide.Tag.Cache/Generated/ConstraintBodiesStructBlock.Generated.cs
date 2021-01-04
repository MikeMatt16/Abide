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
    /// Represents the generated constraint_bodies_struct_block tag block.
    /// </summary>
    public sealed class ConstraintBodiesStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintBodiesStructBlock"/> class.
        /// </summary>
        public ConstraintBodiesStructBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new ShortBlockIndexField("node a*"));
            this.Fields.Add(new ShortBlockIndexField("node b*"));
            this.Fields.Add(new RealField("a scale*"));
            this.Fields.Add(new RealVector3dField("a forward*"));
            this.Fields.Add(new RealVector3dField("a left*"));
            this.Fields.Add(new RealVector3dField("a up*"));
            this.Fields.Add(new RealPoint3dField("a position*"));
            this.Fields.Add(new RealField("b scale*"));
            this.Fields.Add(new RealVector3dField("b forward*"));
            this.Fields.Add(new RealVector3dField("b left*"));
            this.Fields.Add(new RealVector3dField("b up*"));
            this.Fields.Add(new RealPoint3dField("b position*"));
            this.Fields.Add(new ShortBlockIndexField("edge index*"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the constraint_bodies_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "constraint_bodies_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the constraint_bodies_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "constraint_bodies_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the constraint_bodies_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the constraint_bodies_struct_block tag block.
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
