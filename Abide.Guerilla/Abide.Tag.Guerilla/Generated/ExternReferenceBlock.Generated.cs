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
    /// Represents the generated extern_reference_block tag block.
    /// </summary>
    public sealed class ExternReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternReferenceBlock"/> class.
        /// </summary>
        public ExternReferenceBlock()
        {
            this.Fields.Add(new CharIntegerField("parameter index"));
            this.Fields.Add(new CharIntegerField("extern index"));
        }
        /// <summary>
        /// Gets and returns the name of the extern_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "extern_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the extern_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "extern_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the extern_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the extern_reference_block tag block.
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
