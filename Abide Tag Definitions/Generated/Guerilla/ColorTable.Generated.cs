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
    /// Represents the generated color_table (colo) tag group.
    /// </summary>
    public class ColorTable : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorTable"/> class.
        /// </summary>
        public ColorTable()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ColorTableBlock());
        }
        /// <summary>
        /// Gets and returns the name of the color_table tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "color_table";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the color_table tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "colo";
            }
        }
    }
}
