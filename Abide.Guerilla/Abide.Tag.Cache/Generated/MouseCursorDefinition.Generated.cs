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
    /// Represents the generated mouse_cursor_definition (mcsr) tag group.
    /// </summary>
    public class MouseCursorDefinition : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseCursorDefinition"/> class.
        /// </summary>
        public MouseCursorDefinition()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new MouseCursorDefinitionBlock());
        }
        /// <summary>
        /// Gets and returns the name of the mouse_cursor_definition tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "mouse_cursor_definition";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the mouse_cursor_definition tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "mcsr";
            }
        }
    }
}
