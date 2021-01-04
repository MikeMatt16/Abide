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
    /// Represents the generated orders_block tag block.
    /// </summary>
    public sealed class OrdersBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersBlock"/> class.
        /// </summary>
        public OrdersBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new ShortBlockIndexField("Style"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new LongFlagsField("flags", "locked", "always active", "debug on", "strict area def", "follow closest player", "follow squad", "active camo", "suppress combat until engaged", "inhibit vehicle use"));
            this.Fields.Add(new EnumField("Force combat status", "NONE", "Asleep", "Idle", "Alert", "Combat"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringField("Entry Script"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new ShortBlockIndexField("Follow squad"));
            this.Fields.Add(new RealField("follow radius"));
            this.Fields.Add(new BlockField<ZoneSetBlock>("Primary area set", 32));
            this.Fields.Add(new BlockField<SecondaryZoneSetBlock>("Secondary area set", 32));
            this.Fields.Add(new BlockField<SecondarySetTriggerBlock>("Secondary set trigger", 1));
            this.Fields.Add(new BlockField<SpecialMovementBlock>("Special movement", 1));
            this.Fields.Add(new BlockField<OrderEndingBlock>("Order endings", 12));
        }
        /// <summary>
        /// Gets and returns the name of the orders_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "orders_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the orders_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "orders_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the orders_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 300;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the orders_block tag block.
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
