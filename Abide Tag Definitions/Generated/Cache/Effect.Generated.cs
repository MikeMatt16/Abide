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
    /// Represents the generated effect (effe) tag group.
    /// </summary>
    public class Effect : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Effect"/> class.
        /// </summary>
        public Effect()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new EffectBlock());
        }
        /// <summary>
        /// Gets and returns the name of the effect tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "effect";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the effect tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "effe";
            }
        }
    }
}
