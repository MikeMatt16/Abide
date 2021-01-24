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
    /// Represents the generated model_animation_graph_block tag block.
    /// </summary>
    public sealed class ModelAnimationGraphBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAnimationGraphBlock"/> class.
        /// </summary>
        public ModelAnimationGraphBlock()
        {
            this.Fields.Add(new StructField<AnimationGraphResourcesStructBlock>("resources"));
            this.Fields.Add(new StructField<AnimationGraphContentsStructBlock>("content"));
            this.Fields.Add(new StructField<ModelAnimationRuntimeDataStructBlock>("run time data"));
            this.Fields.Add(new ExplanationField("RESULTS OF THE LAST IMPORT", ""));
            this.Fields.Add(new DataField("last import results*", 1, 4));
            this.Fields.Add(new BlockField<AdditionalNodeDataBlock>("additional node data", 255));
            this.Fields.Add(new BlockField<XboxAnimationDataBlock>("animation data", 32767));
            this.Fields.Add(new BlockField<XboxUnknownAnimationBlock>("", 32767));
        }
        /// <summary>
        /// Gets and returns the name of the model_animation_graph_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "model_animation_graph_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_animation_graph_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "model_animation_graph";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_animation_graph_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_animation_graph_block tag block.
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
