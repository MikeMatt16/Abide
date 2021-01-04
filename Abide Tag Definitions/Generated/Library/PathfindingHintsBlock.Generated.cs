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
    /// Represents the generated pathfinding_hints_block tag block.
    /// </summary>
    public sealed class PathfindingHintsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathfindingHintsBlock"/> class.
        /// </summary>
        public PathfindingHintsBlock()
        {
            this.Fields.Add(new EnumField("hint type", "intersection link", "jump link", "climb link", "vault link", "mount link", "hoist link", "wall jump link", "breakable floor"));
            this.Fields.Add(new ShortIntegerField("Next hint index"));
            this.Fields.Add(new ShortIntegerField("hint data 0*"));
            this.Fields.Add(new ShortIntegerField("hint data 1*"));
            this.Fields.Add(new ShortIntegerField("hint data 2*"));
            this.Fields.Add(new ShortIntegerField("hint data 3*"));
            this.Fields.Add(new ShortIntegerField("hint data 4*"));
            this.Fields.Add(new ShortIntegerField("hint data 5*"));
            this.Fields.Add(new ShortIntegerField("hint data 6*"));
            this.Fields.Add(new ShortIntegerField("hint data 7*"));
        }
        /// <summary>
        /// Gets and returns the name of the pathfinding_hints_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "pathfinding_hints_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pathfinding_hints_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pathfinding_hints_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pathfinding_hints_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32767;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pathfinding_hints_block tag block.
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
