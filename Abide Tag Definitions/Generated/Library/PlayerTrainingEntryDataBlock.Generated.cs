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
    /// Represents the generated player_training_entry_data_block tag block.
    /// </summary>
    public sealed class PlayerTrainingEntryDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerTrainingEntryDataBlock"/> class.
        /// </summary>
        public PlayerTrainingEntryDataBlock()
        {
            this.Fields.Add(new StringIdField("display string#comes out of the HUD text globals"));
            this.Fields.Add(new StringIdField("display string2#comes out of the HUD text globals, used for grouped prompt"));
            this.Fields.Add(new StringIdField("display string3#comes out of the HUD text globals, used for ungrouped prompt"));
            this.Fields.Add(new ShortIntegerField("max display time#how long the message can be on screen before being hidden"));
            this.Fields.Add(new ShortIntegerField("display count#how many times a training message will get displayed (0-3 only!)"));
            this.Fields.Add(new ShortIntegerField("dissapear delay#how long a displayed but untriggered message stays up"));
            this.Fields.Add(new ShortIntegerField("redisplay delay#how long after display this message will stay hidden"));
            this.Fields.Add(new RealField("display delay (s)#how long the event can be triggered before it\'s displayed"));
            this.Fields.Add(new WordFlagsField("flags", "not in multiplayer"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the player_training_entry_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "player_training_entry_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the player_training_entry_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "player_training_entry_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the player_training_entry_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the player_training_entry_data_block tag block.
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
