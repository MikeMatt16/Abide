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
    /// Represents the generated mouse_cursor_definition_block tag block.
    /// </summary>
    public sealed class MouseCursorDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseCursorDefinitionBlock"/> class.
        /// </summary>
        public MouseCursorDefinitionBlock()
        {
            this.Fields.Add(new ExplanationField("Mouse Cursor Bitmaps", "0 - Normal mouse cursor\n1 - Busy mouse cursor\n2 - Hover mouse cursor\n3 - Text sel" +
                        "ect mouse cursor\n"));
            this.Fields.Add(new BlockField<MouseCursorBitmapReferenceBlock>("mouse cursor bitmaps", 4));
            this.Fields.Add(new RealField("animation speed (fps)"));
        }
        /// <summary>
        /// Gets and returns the name of the mouse_cursor_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "mouse_cursor_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the mouse_cursor_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mouse_cursor_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the mouse_cursor_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the mouse_cursor_definition_block tag block.
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
