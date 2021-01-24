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
    /// Represents the generated collision_model_block tag block.
    /// </summary>
    public sealed class CollisionModelBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModelBlock"/> class.
        /// </summary>
        public CollisionModelBlock()
        {
            this.Fields.Add(new BlockField<GlobalTagImportInfoBlock>("import info*", 1));
            this.Fields.Add(new BlockField<GlobalErrorReportCategoriesBlock>("errors*", 64));
            this.Fields.Add(new LongFlagsField("flags*", "contains open edges"));
            this.Fields.Add(new BlockField<CollisionModelMaterialBlock>("materials*", 32));
            this.Fields.Add(new BlockField<CollisionModelRegionBlock>("regions*", 16));
            this.Fields.Add(new BlockField<CollisionModelPathfindingSphereBlock>("pathfinding spheres*", 32));
            this.Fields.Add(new BlockField<CollisionModelNodeBlock>("nodes*", 255));
        }
        /// <summary>
        /// Gets and returns the name of the collision_model_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "collision_model_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_model_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "collision_model";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_model_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_model_block tag block.
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
