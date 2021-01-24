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
    /// Represents the generated global_tag_import_info_block tag block.
    /// </summary>
    public sealed class GlobalTagImportInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalTagImportInfoBlock"/> class.
        /// </summary>
        public GlobalTagImportInfoBlock()
        {
            this.Fields.Add(new LongIntegerField("build*"));
            this.Fields.Add(new LongStringField("version*"));
            this.Fields.Add(new StringField("import date*"));
            this.Fields.Add(new StringField("culprit*"));
            this.Fields.Add(new PadField("", 96));
            this.Fields.Add(new StringField("import time*"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new BlockField<TagImportFileBlock>("files*", 1024));
            this.Fields.Add(new PadField("", 128));
        }
        /// <summary>
        /// Gets and returns the name of the global_tag_import_info_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_tag_import_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_tag_import_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "import info";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_tag_import_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_tag_import_info_block tag block.
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
