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
    /// Represents the generated model_variant_block tag block.
    /// </summary>
    public sealed class ModelVariantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVariantBlock"/> class.
        /// </summary>
        public ModelVariantBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new CharBlockIndexField("model varient 1"));
            this.Fields.Add(new CharBlockIndexField("model varient 2"));
            this.Fields.Add(new CharBlockIndexField("model varient 3"));
            this.Fields.Add(new CharBlockIndexField("model varient 4"));
            this.Fields.Add(new CharBlockIndexField("model varient 5"));
            this.Fields.Add(new CharBlockIndexField("model varient 6"));
            this.Fields.Add(new CharBlockIndexField("model varient 7"));
            this.Fields.Add(new CharBlockIndexField("model varient 8"));
            this.Fields.Add(new CharBlockIndexField("model varient 9"));
            this.Fields.Add(new CharBlockIndexField("model varient 10"));
            this.Fields.Add(new CharBlockIndexField("model varient 11"));
            this.Fields.Add(new CharBlockIndexField("model varient 12"));
            this.Fields.Add(new CharBlockIndexField("model varient 13"));
            this.Fields.Add(new CharBlockIndexField("model varient 14"));
            this.Fields.Add(new CharBlockIndexField("model varient 15"));
            this.Fields.Add(new CharBlockIndexField("model varient 16"));
            this.Fields.Add(new BlockField<ModelVariantRegionBlock>("regions", 16));
            this.Fields.Add(new BlockField<ModelVariantObjectBlock>("objects", 16));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new StringIdField("dialogue sound effect"));
            this.Fields.Add(new TagReferenceField("dialogue", 1969515623));
        }
        /// <summary>
        /// Gets and returns the name of the model_variant_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "model_variant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_variant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "variant";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_variant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_variant_block tag block.
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
