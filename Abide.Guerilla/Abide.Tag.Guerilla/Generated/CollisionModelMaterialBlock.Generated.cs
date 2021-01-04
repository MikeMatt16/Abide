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
    /// Represents the generated collision_model_material_block tag block.
    /// </summary>
    public sealed class CollisionModelMaterialBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModelMaterialBlock"/> class.
        /// </summary>
        public CollisionModelMaterialBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
        }
        /// <summary>
        /// Gets and returns the name of the collision_model_material_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "collision_model_material_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_model_material_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_model_material_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_model_material_block tag block.
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
