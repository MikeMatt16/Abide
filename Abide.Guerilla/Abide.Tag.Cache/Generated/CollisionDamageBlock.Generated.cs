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
    /// Represents the generated collision_damage_block tag block.
    /// </summary>
    public sealed class CollisionDamageBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionDamageBlock"/> class.
        /// </summary>
        public CollisionDamageBlock()
        {
            this.Fields.Add(new TagReferenceField("collision damage", 1785754657));
            this.Fields.Add(new RealField("min game acc (default)#0-oo"));
            this.Fields.Add(new RealField("max game acc (default)#0-oo"));
            this.Fields.Add(new RealField("min game scale (default)#0-1"));
            this.Fields.Add(new RealField("max game scale (default)#0-1"));
            this.Fields.Add(new RealField("min abs acc (default)#0-oo"));
            this.Fields.Add(new RealField("max abs acc (default)#0-oo"));
            this.Fields.Add(new RealField("min abs scale (default)#0-1"));
            this.Fields.Add(new RealField("max abs scale (default)#0-1"));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the collision_damage_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "collision_damage_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_damage_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "collision_damage_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_damage_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_damage_block tag block.
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
