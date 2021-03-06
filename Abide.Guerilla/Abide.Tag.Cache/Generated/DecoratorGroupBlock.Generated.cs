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
    /// Represents the generated decorator_group_block tag block.
    /// </summary>
    public sealed class DecoratorGroupBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorGroupBlock"/> class.
        /// </summary>
        public DecoratorGroupBlock()
        {
            this.Fields.Add(new CharBlockIndexField("Decorator Set*"));
            this.Fields.Add(new CharEnumField("Decorator Type", "model", "floating decal", "projected decal", "screen facing quad", "axis rotating quad", "cross quad"));
            this.Fields.Add(new CharIntegerField("Shader Index*"));
            this.Fields.Add(new CharIntegerField("Compressed Radius*"));
            this.Fields.Add(new ShortIntegerField("Cluster*"));
            this.Fields.Add(new ShortBlockIndexField("Cache Block*"));
            this.Fields.Add(new ShortIntegerField("Decorator Start Index*"));
            this.Fields.Add(new ShortIntegerField("Decorator Count*"));
            this.Fields.Add(new ShortIntegerField("Vertex Start Offset*"));
            this.Fields.Add(new ShortIntegerField("Vertex Count*"));
            this.Fields.Add(new ShortIntegerField("Index Start Offset*"));
            this.Fields.Add(new ShortIntegerField("Index Count*"));
            this.Fields.Add(new LongIntegerField("Compressed Bounding Center*"));
        }
        /// <summary>
        /// Gets and returns the name of the decorator_group_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "decorator_group_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the decorator_group_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "decorator_group_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the decorator_group_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the decorator_group_block tag block.
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
