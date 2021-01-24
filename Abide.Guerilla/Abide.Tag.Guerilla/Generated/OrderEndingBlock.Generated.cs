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
    /// Represents the generated order_ending_block tag block.
    /// </summary>
    public sealed class OrderEndingBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderEndingBlock"/> class.
        /// </summary>
        public OrderEndingBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("next order^"));
            this.Fields.Add(new EnumField("combination rule", "OR", "AND"));
            this.Fields.Add(new RealField("delay time"));
            this.Fields.Add(new EnumField("dialogue type#when this ending is triggered, launch a dialogue event of the given" +
                        " type", "none", "advance", "charge", "fall_back", "retreat", "moveone", "arrival", "enter_vehicle", "exit_vehicle", "follow_player", "leave_player", "support"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<TriggerReferences>("triggers", 10));
        }
        /// <summary>
        /// Gets and returns the name of the order_ending_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "order_ending_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the order_ending_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "order_ending_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the order_ending_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 12;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the order_ending_block tag block.
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
