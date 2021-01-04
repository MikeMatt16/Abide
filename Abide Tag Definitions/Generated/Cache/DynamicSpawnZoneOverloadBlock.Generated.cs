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
    /// Represents the generated dynamic_spawn_zone_overload_block tag block.
    /// </summary>
    public sealed class DynamicSpawnZoneOverloadBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSpawnZoneOverloadBlock"/> class.
        /// </summary>
        public DynamicSpawnZoneOverloadBlock()
        {
            this.Fields.Add(new EnumField("Overload Type", "Enemy", "Friend", "Enemy Vehicle", "Friendly Vehicle", "Empty Vehicle", "Oddball Inclusion", "Oddball Exclusion", "Hill Inclusion", "Hill Exclusion", "Last Race Flag", "Dead Ally", "Controlled Territory"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("Inner Radius"));
            this.Fields.Add(new RealField("Outer Radius"));
            this.Fields.Add(new RealField("Weight"));
        }
        /// <summary>
        /// Gets and returns the name of the dynamic_spawn_zone_overload_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "dynamic_spawn_zone_overload_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the dynamic_spawn_zone_overload_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "dynamic_spawn_zone_overload_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the dynamic_spawn_zone_overload_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the dynamic_spawn_zone_overload_block tag block.
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
