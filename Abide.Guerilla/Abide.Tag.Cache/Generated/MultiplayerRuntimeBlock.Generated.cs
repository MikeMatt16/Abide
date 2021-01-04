//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated multiplayer_runtime_block tag block.
    /// </summary>
    public sealed class MultiplayerRuntimeBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplayerRuntimeBlock"/> class.
        /// </summary>
        public MultiplayerRuntimeBlock()
        {
            this.Fields.Add(new TagReferenceField("flag", 1769235821));
            this.Fields.Add(new TagReferenceField("ball", 1769235821));
            this.Fields.Add(new TagReferenceField("unit", 1970170228));
            this.Fields.Add(new TagReferenceField("flag shader", 1936220516));
            this.Fields.Add(new TagReferenceField("hill shader", 1936220516));
            this.Fields.Add(new TagReferenceField("head", 1769235821));
            this.Fields.Add(new TagReferenceField("juggernaut powerup", 1769235821));
            this.Fields.Add(new TagReferenceField("da bomb", 1769235821));
            this.Fields.Add(new TagReferenceField("", -3));
            this.Fields.Add(new TagReferenceField("", -3));
            this.Fields.Add(new TagReferenceField("", -3));
            this.Fields.Add(new TagReferenceField("", -3));
            this.Fields.Add(new TagReferenceField("", -3));
            this.Fields.Add(new BlockField<WeaponsBlock>("weapons", 20));
            this.Fields.Add(new BlockField<VehiclesBlock>("vehicles", 20));
            this.Fields.Add(new StructField<GrenadeAndPowerupStructBlock>("arr!"));
            this.Fields.Add(new TagReferenceField("in game text", 1970170211));
            this.Fields.Add(new BlockField<SoundsBlock>("sounds", 60));
            this.Fields.Add(new BlockField<GameEngineGeneralEventBlock>("general events", 128));
            this.Fields.Add(new BlockField<GameEngineFlavorEventBlock>("flavor events", 128));
            this.Fields.Add(new BlockField<GameEngineSlayerEventBlock>("slayer events", 128));
            this.Fields.Add(new BlockField<GameEngineCtfEventBlock>("ctf events", 128));
            this.Fields.Add(new BlockField<GameEngineOddballEventBlock>("oddball events", 128));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GameEngineKingEventBlock>("king events", 128));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GameEngineJuggernautEventBlock>("juggernaut events", 128));
            this.Fields.Add(new BlockField<GameEngineTerritoriesEventBlock>("territories events", 128));
            this.Fields.Add(new BlockField<GameEngineAssaultEventBlock>("invasion events", 128));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new TagReferenceField("default item collection 1", 1769237859));
            this.Fields.Add(new TagReferenceField("default item collection 2", 1769237859));
            this.Fields.Add(new LongIntegerField("default frag grenade count"));
            this.Fields.Add(new LongIntegerField("default plasma grenade count"));
            this.Fields.Add(new PadField("", 40));
            this.Fields.Add(new ExplanationField("dynamic spawn zones", ""));
            this.Fields.Add(new RealField("dynamic zone upper height"));
            this.Fields.Add(new RealField("dynamic zone lower height"));
            this.Fields.Add(new PadField("", 40));
            this.Fields.Add(new ExplanationField("enemy", ""));
            this.Fields.Add(new RealField("enemy inner radius"));
            this.Fields.Add(new RealField("enemy outer radius"));
            this.Fields.Add(new RealField("enemy weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("friend", ""));
            this.Fields.Add(new RealField("friend inner radius"));
            this.Fields.Add(new RealField("friend outer radius"));
            this.Fields.Add(new RealField("friend weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("enemy vehicle", ""));
            this.Fields.Add(new RealField("enemy vehicle inner radius"));
            this.Fields.Add(new RealField("enemy vehicle outer radius"));
            this.Fields.Add(new RealField("enemy vehicle weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("friendly vehicle", ""));
            this.Fields.Add(new RealField("friendly vehicle inner radius"));
            this.Fields.Add(new RealField("friendly vehicle outer radius"));
            this.Fields.Add(new RealField("friendly vehicle weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("empty vehicle", ""));
            this.Fields.Add(new RealField("empty vehicle inner radius"));
            this.Fields.Add(new RealField("empty vehicle outer radius"));
            this.Fields.Add(new RealField("empty vehicle weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("oddball inclusion", ""));
            this.Fields.Add(new RealField("oddball inclusion inner radius"));
            this.Fields.Add(new RealField("oddball inclusion outer radius"));
            this.Fields.Add(new RealField("oddball inclusion weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("oddball exclusion", ""));
            this.Fields.Add(new RealField("oddball exclusion inner radius"));
            this.Fields.Add(new RealField("oddball exclusion outer radius"));
            this.Fields.Add(new RealField("oddball exclusion weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("hill inclusion", ""));
            this.Fields.Add(new RealField("hill inclusion inner radius"));
            this.Fields.Add(new RealField("hill inclusion outer radius"));
            this.Fields.Add(new RealField("hill inclusion weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("hill exclusion", ""));
            this.Fields.Add(new RealField("hill exclusion inner radius"));
            this.Fields.Add(new RealField("hill exclusion outer radius"));
            this.Fields.Add(new RealField("hill exclusion weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("last race flag", ""));
            this.Fields.Add(new RealField("last race flag inner radius"));
            this.Fields.Add(new RealField("last race flag outer radius"));
            this.Fields.Add(new RealField("last race flag weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("dead ally", ""));
            this.Fields.Add(new RealField("dead ally inner radius"));
            this.Fields.Add(new RealField("dead ally outer radius"));
            this.Fields.Add(new RealField("dead ally weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("controlled territory", ""));
            this.Fields.Add(new RealField("controlled territory inner radius"));
            this.Fields.Add(new RealField("controlled territory outer radius"));
            this.Fields.Add(new RealField("controlled territory weight"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 560));
            this.Fields.Add(new PadField("", 48));
            this.Fields.Add(new BlockField<MultiplayerConstantsBlock>("multiplayer constants", 1));
            this.Fields.Add(new BlockField<GameEngineStatusResponseBlock>("state responses", 32));
            this.Fields.Add(new TagReferenceField("scoreboard hud definition", 1852335220));
            this.Fields.Add(new TagReferenceField("scoreboard emblem shader", 1936220516));
            this.Fields.Add(new TagReferenceField("scoreboard emblem bitmap", 1651078253));
            this.Fields.Add(new TagReferenceField("scoreboard dead emblem shader", 1936220516));
            this.Fields.Add(new TagReferenceField("scoreboard dead emblem bitmap", 1651078253));
        }
        /// <summary>
        /// Gets and returns the name of the multiplayer_runtime_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "multiplayer_runtime_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the multiplayer_runtime_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "multiplayer_runtime_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the multiplayer_runtime_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the multiplayer_runtime_block tag block.
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
