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
    /// Represents the generated object_ai_properties_block tag block.
    /// </summary>
    public sealed class ObjectAiPropertiesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectAiPropertiesBlock"/> class.
        /// </summary>
        public ObjectAiPropertiesBlock()
        {
            this.Fields.Add(new LongFlagsField("ai flags", "detroyable cover", "pathfinding ignore when dead", "dynamic cover"));
            this.Fields.Add(new StringIdField("ai type name#used for combat dialogue, etc."));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new EnumField("ai size", "default", "tiny", "small", "medium", "large", "huge", "immobile"));
            this.Fields.Add(new EnumField("leap jump speed", "NONE", "down", "step", "crouch", "stand", "storey", "tower", "infinite"));
        }
        /// <summary>
        /// Gets and returns the name of the object_ai_properties_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "object_ai_properties_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_ai_properties_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_ai_properties_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_ai_properties_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_ai_properties_block tag block.
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
