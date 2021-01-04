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
    /// Represents the generated cellular_automata (devo) tag group.
    /// </summary>
    public class CellularAutomata : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CellularAutomata"/> class.
        /// </summary>
        public CellularAutomata()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new CellularAutomataBlock());
        }
        /// <summary>
        /// Gets and returns the name of the cellular_automata tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "cellular_automata";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the cellular_automata tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "devo";
            }
        }
    }
}
