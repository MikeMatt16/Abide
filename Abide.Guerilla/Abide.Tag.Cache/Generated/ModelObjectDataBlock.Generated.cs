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
    /// Represents the generated model_object_data_block tag block.
    /// </summary>
    public sealed class ModelObjectDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelObjectDataBlock"/> class.
        /// </summary>
        public ModelObjectDataBlock()
        {
            this.Fields.Add(new EnumField("type*", "not set", "user defined", "auto generated"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealPoint3dField("offset*"));
            this.Fields.Add(new RealField("radius*"));
        }
        /// <summary>
        /// Gets and returns the name of the model_object_data_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "model_object_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_object_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "model_object_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_object_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_object_data_block tag block.
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
