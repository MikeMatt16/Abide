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
    /// Represents the generated ai_conversation_participant_block tag block.
    /// </summary>
    public sealed class AiConversationParticipantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiConversationParticipantBlock"/> class.
        /// </summary>
        public AiConversationParticipantBlock()
        {
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new ShortBlockIndexField("use this object#if a unit with this name exists, we try to pick them to start the" +
                        " conversation"));
            this.Fields.Add(new ShortBlockIndexField("set new name#once we pick a unit, we name it this"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new StringField("encounter name"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 12));
        }
        /// <summary>
        /// Gets and returns the name of the ai_conversation_participant_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ai_conversation_participant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_conversation_participant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_conversation_participant_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_conversation_participant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_conversation_participant_block tag block.
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
