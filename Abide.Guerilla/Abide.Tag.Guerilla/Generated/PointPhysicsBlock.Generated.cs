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
    /// Represents the generated point_physics_block tag block.
    /// </summary>
    public sealed class PointPhysicsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointPhysicsBlock"/> class.
        /// </summary>
        public PointPhysicsBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "UNUSED", "collides with structures", "collides with water surface", "uses simple wind#the wind on this point won\'t have high-frequency variations", "uses damped wind#the wind on this point will be artificially slow", "no gravity#the point is not affected by gravity"));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new RealField("density:g/mL"));
            this.Fields.Add(new RealField("air friction"));
            this.Fields.Add(new RealField("water friction"));
            this.Fields.Add(new RealField("surface friction#when hitting the ground or interior, percentage of velocity lost" +
                        " in one collision"));
            this.Fields.Add(new RealField("elasticity#0.0 is inelastic collisions (no bounce) 1.0 is perfectly elastic (refl" +
                        "ected velocity equals incoming velocity)"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new ExplanationField("Densities (g/mL)", @"air        0.0011 (g/mL)
snow       0.128
cork       0.24
cedar      0.43
oak        0.866
ice        0.897
water      1.0
soil       1.1
cotton     1.491
dry earth  1.52
sand       1.7
granite    2.4
glass      2.5
iron       7.65
steel      7.77
lead       11.37
uranium    18.74
gold       19.3
"));
        }
        /// <summary>
        /// Gets and returns the name of the point_physics_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "point_physics_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the point_physics_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "point_physics";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the point_physics_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the point_physics_block tag block.
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
