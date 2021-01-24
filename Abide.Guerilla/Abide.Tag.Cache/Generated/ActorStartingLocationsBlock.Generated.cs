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
    /// Represents the generated actor_starting_locations_block tag block.
    /// </summary>
    public sealed class ActorStartingLocationsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStartingLocationsBlock"/> class.
        /// </summary>
        public ActorStartingLocationsBlock()
        {
            this.Fields.Add(new OldStringIdField("name^"));
            this.Fields.Add(new RealPoint3dField("position"));
            this.Fields.Add(new ShortIntegerField("reference frame*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EulerAngles2dField("facing (yaw, pitch):degrees"));
            this.Fields.Add(new LongFlagsField("flags", "initially asleep", "infection form explode", "n/a", "always place", "initially hidden"));
            this.Fields.Add(new ShortBlockIndexField("character type"));
            this.Fields.Add(new ShortBlockIndexField("initial weapon"));
            this.Fields.Add(new ShortBlockIndexField("initial secondary weapon"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBlockIndexField("vehicle type"));
            this.Fields.Add(new EnumField("seat type", "DEFAULT", "passenger", "gunner", "driver", "small cargo", "large cargo", "NO driver", "NO vehicle"));
            this.Fields.Add(new EnumField("grenade type", "NONE", "Human grenade", "Covenant Plasma"));
            this.Fields.Add(new ShortIntegerField("swarm count#number of cretures in swarm if a swarm is spawned at this location"));
            this.Fields.Add(new StringIdField("actor variant name"));
            this.Fields.Add(new StringIdField("vehicle variant name"));
            this.Fields.Add(new RealField("initial movement distance#before doing anything else, the actor will travel the g" +
                        "iven distance in its forward direction"));
            this.Fields.Add(new ShortBlockIndexField("emitter vehicle"));
            this.Fields.Add(new EnumField("initial movement mode", "default", "climbing", "flying"));
            this.Fields.Add(new StringField("Placement script"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the actor_starting_locations_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "actor_starting_locations_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the actor_starting_locations_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "actor_starting_locations_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the actor_starting_locations_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the actor_starting_locations_block tag block.
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
