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
    /// Represents the generated cloth_block tag block.
    /// </summary>
    public sealed class ClothBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClothBlock"/> class.
        /// </summary>
        public ClothBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "Doesn\'t use wind", "Uses grid attach top"));
            this.Fields.Add(new StringIdField("marker attachment name"));
            this.Fields.Add(new TagReferenceField("Shader", 1936220516));
            this.Fields.Add(new ExplanationField("Default cloth vertices", "if not importing from a render model, type a grid size"));
            this.Fields.Add(new ShortIntegerField("grid x dimension"));
            this.Fields.Add(new ShortIntegerField("grid y dimension"));
            this.Fields.Add(new RealField("grid spacing x"));
            this.Fields.Add(new RealField("grid spacing y"));
            this.Fields.Add(new ExplanationField("Cloth Properties", ""));
            this.Fields.Add(new StructField<ClothPropertiesBlock>("properties"));
            this.Fields.Add(new ExplanationField("Import or grid data", ""));
            this.Fields.Add(new BlockField<ClothVerticesBlock>("vertices*", 128));
            this.Fields.Add(new BlockField<ClothIndicesBlock>("indices*", 768));
            this.Fields.Add(new BlockField<ClothIndicesBlock>("strip indices*", 768));
            this.Fields.Add(new BlockField<ClothLinksBlock>("links*", 640));
        }
        /// <summary>
        /// Gets and returns the name of the cloth_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "cloth_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cloth_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cloth";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cloth_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cloth_block tag block.
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
