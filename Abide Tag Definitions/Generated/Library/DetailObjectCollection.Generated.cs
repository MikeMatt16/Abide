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
    /// Represents the generated detail_object_collection (dobc) tag group.
    /// </summary>
    public class DetailObjectCollection : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailObjectCollection"/> class.
        /// </summary>
        public DetailObjectCollection()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new DetailObjectCollectionBlock());
        }
        /// <summary>
        /// Gets and returns the name of the detail_object_collection tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "detail_object_collection";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the detail_object_collection tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "dobc";
            }
        }
    }
}
