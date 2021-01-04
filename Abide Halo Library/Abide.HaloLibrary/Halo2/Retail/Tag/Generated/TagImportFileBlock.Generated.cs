//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated tag_import_file_block tag block.
    /// </summary>
    public sealed class TagImportFileBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagImportFileBlock"/> class.
        /// </summary>
        public TagImportFileBlock()
        {
            this.Fields.Add(new LongStringField("path*"));
            this.Fields.Add(new StringField("modification date*"));
            this.Fields.Add(new SkipField("", 8));
            this.Fields.Add(new PadField("", 88));
            this.Fields.Add(new LongIntegerField("checksum*:crc32"));
            this.Fields.Add(new LongIntegerField("size*:bytes"));
            this.Fields.Add(new DataField("zipped data*", 1, 4));
            this.Fields.Add(new PadField("", 128));
        }
        /// <summary>
        /// Gets and returns the name of the tag_import_file_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "tag_import_file_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the tag_import_file_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "import file";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the tag_import_file_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the tag_import_file_block tag block.
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
