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
    /// Represents the generated ui_object_reference_block tag block.
    /// </summary>
    public sealed class UiObjectReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiObjectReferenceBlock"/> class.
        /// </summary>
        public UiObjectReferenceBlock()
        {
            this.Fields.Add(new StringField("name"));
        }
        /// <summary>
        /// Gets and returns the name of the ui_object_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "ui_object_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ui_object_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ui_object_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ui_object_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ui_object_reference_block tag block.
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
