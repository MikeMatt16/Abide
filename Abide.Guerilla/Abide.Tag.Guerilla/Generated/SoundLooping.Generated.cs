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
    /// Represents the generated sound_looping (lsnd) tag group.
    /// </summary>
    public class SoundLooping : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundLooping"/> class.
        /// </summary>
        public SoundLooping()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new SoundLoopingBlock());
        }
        /// <summary>
        /// Gets and returns the name of the sound_looping tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "sound_looping";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the sound_looping tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "lsnd";
            }
        }
    }
}
