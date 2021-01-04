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
    /// Represents the generated friction_point_definition_block tag block.
    /// </summary>
    public sealed class FrictionPointDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionPointDefinitionBlock"/> class.
        /// </summary>
        public FrictionPointDefinitionBlock()
        {
            this.Fields.Add(new StringIdField("marker name^"));
            this.Fields.Add(new LongFlagsField("flags", "gets damage from region", "powered", "front turning", "rear turning", "attached to e-brake", "can be destroyed"));
            this.Fields.Add(new RealField("fraction of total mass#(0.0-1.0) fraction of total vehicle mass"));
            this.Fields.Add(new RealField("radius"));
            this.Fields.Add(new RealField("damaged radius#radius when the tire is blown off."));
            this.Fields.Add(new EnumField("friction type", "point", "forward"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("moving friction velocity diff"));
            this.Fields.Add(new RealField("e-brake moving friction"));
            this.Fields.Add(new RealField("e-brake friction"));
            this.Fields.Add(new RealField("e-brake moving friction vel diff"));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new StringIdField("collision global material name"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("friction point destruction data", ""));
            this.Fields.Add(new EnumField("model state destroyed#only need point can destroy flag set", "default", "minor damage", "medium damage", "major damage", "destroyed"));
            this.Fields.Add(new StringIdField("region name#only need point can destroy flag set"));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the friction_point_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "friction_point_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the friction_point_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "friction_point_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the friction_point_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the friction_point_definition_block tag block.
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
