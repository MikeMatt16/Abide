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
    /// Represents the generated user_hint_polygon_block tag block.
    /// </summary>
    public sealed class UserHintPolygonBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHintPolygonBlock"/> class.
        /// </summary>
        public UserHintPolygonBlock()
        {
            this.Fields.Add(new LongFlagsField("Flags", "bidirectional", "closed"));
            this.Fields.Add(new BlockField<UserHintPointBlock>("Points", 200));
        }
        /// <summary>
        /// Gets and returns the name of the user_hint_polygon_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "user_hint_polygon_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the user_hint_polygon_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "user_hint_polygon_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the user_hint_polygon_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 200;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the user_hint_polygon_block tag block.
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
