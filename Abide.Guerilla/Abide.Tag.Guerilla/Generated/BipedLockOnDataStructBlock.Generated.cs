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
    /// Represents the generated biped_lock_on_data_struct_block tag block.
    /// </summary>
    public sealed class BipedLockOnDataStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BipedLockOnDataStructBlock"/> class.
        /// </summary>
        public BipedLockOnDataStructBlock()
        {
            this.Fields.Add(new ExplanationField("lock-on fields", ""));
            this.Fields.Add(new LongFlagsField("flags", "locked by human targeting", "locked by plasma targeting", "always locked by plasma targeting"));
            this.Fields.Add(new RealField("lock on distance"));
        }
        /// <summary>
        /// Gets and returns the name of the biped_lock_on_data_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "biped_lock_on_data_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the biped_lock_on_data_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "biped_lock_on_data_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the biped_lock_on_data_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the biped_lock_on_data_struct_block tag block.
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
