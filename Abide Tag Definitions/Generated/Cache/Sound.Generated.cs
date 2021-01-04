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
    /// Represents the generated sound (snd!) tag group.
    /// </summary>
    public class Sound : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sound"/> class.
        /// </summary>
        public Sound()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new CacheFileSoundBlock());
        }
        /// <summary>
        /// Gets and returns the name of the sound tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "sound";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the sound tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "snd!";
            }
        }
    }
}