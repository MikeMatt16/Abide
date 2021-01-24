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
    /// Represents the generated model_target_lock_on_data_struct_block tag block.
    /// </summary>
    public sealed class ModelTargetLockOnDataStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTargetLockOnDataStructBlock"/> class.
        /// </summary>
        public ModelTargetLockOnDataStructBlock()
        {
            this.Fields.Add(new ExplanationField("lock-on fields", ""));
            this.Fields.Add(new LongFlagsField("flags", "locked by human tracking", "locked by plasma tracking", "headshot", "vulnerable", "alwas locked by plasma tracking"));
            this.Fields.Add(new RealField("lock on distance"));
        }
        /// <summary>
        /// Gets and returns the name of the model_target_lock_on_data_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "model_target_lock_on_data_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_target_lock_on_data_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "model_target_lock_on_data_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_target_lock_on_data_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_target_lock_on_data_struct_block tag block.
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
