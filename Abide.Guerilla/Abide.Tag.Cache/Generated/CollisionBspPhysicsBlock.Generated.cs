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
    /// Represents the generated collision_bsp_physics_block tag block.
    /// </summary>
    public sealed class CollisionBspPhysicsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionBspPhysicsBlock"/> class.
        /// </summary>
        public CollisionBspPhysicsBlock()
        {
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new ShortIntegerField("Size*"));
            this.Fields.Add(new ShortIntegerField("Count*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new SkipField("", 32));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new ShortIntegerField("Size*"));
            this.Fields.Add(new ShortIntegerField("Count*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new ShortIntegerField("Size*"));
            this.Fields.Add(new ShortIntegerField("Count*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new DataField("mopp Code Data*", 1, 16));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the collision_bsp_physics_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "collision_bsp_physics_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_bsp_physics_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "collision_bsp_physics_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_bsp_physics_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_bsp_physics_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
    }
}
