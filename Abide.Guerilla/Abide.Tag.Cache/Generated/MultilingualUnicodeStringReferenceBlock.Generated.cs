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
    /// Represents the generated multilingual_unicode_string_reference_block tag block.
    /// </summary>
    public sealed class MultilingualUnicodeStringReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualUnicodeStringReferenceBlock"/> class.
        /// </summary>
        public MultilingualUnicodeStringReferenceBlock()
        {
            this.Fields.Add(new StringIdField("string id"));
            this.Fields.Add(new LongIntegerField("english offset"));
            this.Fields.Add(new LongIntegerField("japanese offset"));
            this.Fields.Add(new LongIntegerField("german offset"));
            this.Fields.Add(new LongIntegerField("french offset"));
            this.Fields.Add(new LongIntegerField("spanish offset"));
            this.Fields.Add(new LongIntegerField("italian offset"));
            this.Fields.Add(new LongIntegerField("korean offset"));
            this.Fields.Add(new LongIntegerField("chinese offset"));
            this.Fields.Add(new LongIntegerField("portuguese offset"));
        }
        /// <summary>
        /// Gets and returns the name of the multilingual_unicode_string_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "multilingual_unicode_string_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the multilingual_unicode_string_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "multilingual_unicode_string_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the multilingual_unicode_string_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 9216;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the multilingual_unicode_string_reference_block tag block.
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
