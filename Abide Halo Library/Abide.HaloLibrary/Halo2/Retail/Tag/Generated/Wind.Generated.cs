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
    /// Represents the generated wind (wind) tag group.
    /// </summary>
    public class Wind : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wind"/> class.
        /// </summary>
        public Wind()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new WindBlock());
        }
        /// <summary>
        /// Gets and returns the name of the wind tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "wind";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the wind tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "wind";
            }
        }
    }
}
