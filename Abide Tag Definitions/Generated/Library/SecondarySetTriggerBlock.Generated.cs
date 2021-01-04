//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated secondary_set_trigger_block tag block.
    /// </summary>
    public sealed class SecondarySetTriggerBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondarySetTriggerBlock"/> class.
        /// </summary>
        public SecondarySetTriggerBlock()
        {
            this.Fields.Add(new EnumField("combination rule", "OR", "AND"));
            this.Fields.Add(new EnumField("dialogue type#when this ending is triggered, launch a dialogue event of the given" +
                        " type", "none", "advance", "charge", "fall_back", "retreat", "moveone", "arrival", "enter_vehicle", "exit_vehicle", "follow_player", "leave_player", "support"));
            this.Fields.Add(new BlockField<TriggerReferences>("triggers", 10));
        }
        /// <summary>
        /// Gets and returns the name of the secondary_set_trigger_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "secondary_set_trigger_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the secondary_set_trigger_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "secondary_set_trigger_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the secondary_set_trigger_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the secondary_set_trigger_block tag block.
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
