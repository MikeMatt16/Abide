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
    /// Represents the generated old_unused_strucure_physics_block tag block.
    /// </summary>
    public sealed class OldUnusedStrucurePhysicsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OldUnusedStrucurePhysicsBlock"/> class.
        /// </summary>
        public OldUnusedStrucurePhysicsBlock()
        {
            this.Fields.Add(new DataField("*", 1, 16));
            this.Fields.Add(new BlockField<OldUnusedObjectIdentifiersBlock>("*", 2048));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealPoint3dField("mopp Bounds Min*"));
            this.Fields.Add(new RealPoint3dField("mopp Bounds Max*"));
        }
        /// <summary>
        /// Gets and returns the name of the old_unused_strucure_physics_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "old_unused_strucure_physics_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the old_unused_strucure_physics_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "old_unused_strucure_physics_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the old_unused_strucure_physics_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the old_unused_strucure_physics_block tag block.
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
