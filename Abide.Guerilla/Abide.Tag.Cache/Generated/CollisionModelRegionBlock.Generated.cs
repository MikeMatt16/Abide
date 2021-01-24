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
    /// Represents the generated collision_model_region_block tag block.
    /// </summary>
    public sealed class CollisionModelRegionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModelRegionBlock"/> class.
        /// </summary>
        public CollisionModelRegionBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new BlockField<CollisionModelPermutationBlock>("permutations*", 32));
        }
        /// <summary>
        /// Gets and returns the name of the collision_model_region_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "collision_model_region_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_model_region_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "region";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_model_region_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_model_region_block tag block.
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
