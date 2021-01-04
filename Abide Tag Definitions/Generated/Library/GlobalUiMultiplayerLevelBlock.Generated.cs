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
    /// Represents the generated global_ui_multiplayer_level_block tag block.
    /// </summary>
    public sealed class GlobalUiMultiplayerLevelBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalUiMultiplayerLevelBlock"/> class.
        /// </summary>
        public GlobalUiMultiplayerLevelBlock()
        {
            this.Fields.Add(new LongIntegerField("Map ID"));
            this.Fields.Add(new TagReferenceField("Bitmap", 1651078253));
            this.Fields.Add(new SkipField("", 576));
            this.Fields.Add(new SkipField("", 2304));
            this.Fields.Add(new LongStringField("Path"));
            this.Fields.Add(new LongIntegerField("Sort Order"));
            this.Fields.Add(new ByteFlagsField("Flags", "Unlockable"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new CharIntegerField("Max Teams None"));
            this.Fields.Add(new CharIntegerField("Max Teams CTF"));
            this.Fields.Add(new CharIntegerField("Max Teams Slayer"));
            this.Fields.Add(new CharIntegerField("Max Teams Oddball"));
            this.Fields.Add(new CharIntegerField("Max Teams KOTH"));
            this.Fields.Add(new CharIntegerField("Max Teams Race"));
            this.Fields.Add(new CharIntegerField("Max Teams Headhunter"));
            this.Fields.Add(new CharIntegerField("Max Teams Juggernaut"));
            this.Fields.Add(new CharIntegerField("Max Teams Territories"));
            this.Fields.Add(new CharIntegerField("Max Teams Assault"));
            this.Fields.Add(new CharIntegerField("Max Teams Stub 10"));
            this.Fields.Add(new CharIntegerField("Max Teams Stub 11"));
            this.Fields.Add(new CharIntegerField("Max Teams Stub 12"));
            this.Fields.Add(new CharIntegerField("Max Teams Stub 13"));
            this.Fields.Add(new CharIntegerField("Max Teams Stub 14"));
            this.Fields.Add(new CharIntegerField("Max Teams Stub 15"));
        }
        /// <summary>
        /// Gets and returns the name of the global_ui_multiplayer_level_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_ui_multiplayer_level_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_ui_multiplayer_level_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_ui_multiplayer_level_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_ui_multiplayer_level_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 50;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_ui_multiplayer_level_block tag block.
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
