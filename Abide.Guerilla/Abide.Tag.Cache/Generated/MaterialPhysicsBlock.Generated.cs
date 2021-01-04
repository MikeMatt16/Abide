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
    /// Represents the generated material_physics_block tag block.
    /// </summary>
    public sealed class MaterialPhysicsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialPhysicsBlock"/> class.
        /// </summary>
        public MaterialPhysicsBlock()
        {
            this.Fields.Add(new ExplanationField("vehicle terrain parameters", "the following fields modify the way a vehicle drives over terrain of this materia" +
                        "l type."));
            this.Fields.Add(new RealField("ground friction scale#fraction of original velocity parallel to the ground after " +
                        "one tick"));
            this.Fields.Add(new RealField("ground friction normal k1 scale#cosine of angle at which friction falls off"));
            this.Fields.Add(new RealField("ground friction normal k0 scale#cosine of angle at which friction is zero"));
            this.Fields.Add(new RealField("ground depth scale#depth a point mass rests in the ground"));
            this.Fields.Add(new RealField("ground damp fraction scale#fraction of original velocity perpendicular to the gro" +
                        "und after one tick"));
        }
        /// <summary>
        /// Gets and returns the name of the material_physics_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "material_physics_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the material_physics_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material_physics";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the material_physics_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the material_physics_block tag block.
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
