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
    /// Represents the generated character_physics_ground_struct_block tag block.
    /// </summary>
    public sealed class CharacterPhysicsGroundStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPhysicsGroundStructBlock"/> class.
        /// </summary>
        public CharacterPhysicsGroundStructBlock()
        {
            this.Fields.Add(new AngleField("maximum slope angle:degrees"));
            this.Fields.Add(new AngleField("downhill falloff angle:degrees"));
            this.Fields.Add(new AngleField("downhill cutoff angle:degrees"));
            this.Fields.Add(new AngleField("uphill falloff angle:degrees"));
            this.Fields.Add(new AngleField("uphill cutoff angle:degrees"));
            this.Fields.Add(new RealField("downhill velocity scale"));
            this.Fields.Add(new RealField("uphill velocity scale"));
            this.Fields.Add(new PadField("", 20));
        }
        /// <summary>
        /// Gets and returns the name of the character_physics_ground_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_physics_ground_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_physics_ground_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_physics_ground_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_physics_ground_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_physics_ground_struct_block tag block.
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
