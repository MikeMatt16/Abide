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
    /// Represents the generated sound_cache_file_gestalt (ugh!) tag group.
    /// </summary>
    public class SoundCacheFileGestalt : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundCacheFileGestalt"/> class.
        /// </summary>
        public SoundCacheFileGestalt()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new SoundCacheFileGestaltBlock());
        }
        /// <summary>
        /// Gets and returns the name of the sound_cache_file_gestalt tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "sound_cache_file_gestalt";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the sound_cache_file_gestalt tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "ugh!";
            }
        }
    }
}
