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
    /// Represents the generated melee_aim_assist_struct_block tag block.
    /// </summary>
    public sealed class MeleeAimAssistStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeleeAimAssistStructBlock"/> class.
        /// </summary>
        public MeleeAimAssistStructBlock()
        {
            this.Fields.Add(new AngleField("magnetism angle:degrees#the maximum angle that magnetism works at full strength"));
            this.Fields.Add(new RealField("magnetism range:world units#the maximum distance that magnetism works at full str" +
                        "ength"));
            this.Fields.Add(new RealField("throttle magnitude"));
            this.Fields.Add(new RealField("throttle minimum distance"));
            this.Fields.Add(new AngleField("throttle maximum adjustment angle:degrees"));
        }
        /// <summary>
        /// Gets and returns the name of the melee_aim_assist_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "melee_aim_assist_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the melee_aim_assist_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "melee_aim_assist_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the melee_aim_assist_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the melee_aim_assist_struct_block tag block.
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
