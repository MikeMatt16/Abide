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
    /// Represents the generated behavior_names_block tag block.
    /// </summary>
    public sealed class BehaviorNamesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BehaviorNamesBlock"/> class.
        /// </summary>
        public BehaviorNamesBlock()
        {
            this.Fields.Add(new StringField("behavior name*^"));
        }
        /// <summary>
        /// Gets and returns the name of the behavior_names_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "behavior_names_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the behavior_names_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "behavior_names_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the behavior_names_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 160;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the behavior_names_block tag block.
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
