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
    /// Represents the generated game_engine_oddball_event_block tag block.
    /// </summary>
    public sealed class GameEngineOddballEventBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameEngineOddballEventBlock"/> class.
        /// </summary>
        public GameEngineOddballEventBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "quantity message"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("event^", "game start", "ball spawned", "ball picked up", "ball dropped", "ball reset", "ball tick"));
            this.Fields.Add(new EnumField("audience^", "cause player", "cause team", "effect player", "effect team", "all"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringIdField("display string"));
            this.Fields.Add(new EnumField("required field", "NONE", "cause player", "cause team", "effect player", "effect team"));
            this.Fields.Add(new EnumField("excluded audience", "NONE", "cause player", "cause team", "effect player", "effect team"));
            this.Fields.Add(new StringIdField("primary string"));
            this.Fields.Add(new LongIntegerField("primary string duration:seconds"));
            this.Fields.Add(new StringIdField("plural display string"));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new RealField("sound delay (announcer only)"));
            this.Fields.Add(new WordFlagsField("sound flags", "announcer sound"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("sound^", 1936614433));
            this.Fields.Add(new StructField<SoundResponseExtraSoundsStructBlock>("extra sounds"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new BlockField<SoundResponseDefinitionBlock>("sound permutations", 10));
        }
        /// <summary>
        /// Gets and returns the name of the game_engine_oddball_event_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "game_engine_oddball_event_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the game_engine_oddball_event_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "game_engine_oddball_event_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the game_engine_oddball_event_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the game_engine_oddball_event_block tag block.
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
