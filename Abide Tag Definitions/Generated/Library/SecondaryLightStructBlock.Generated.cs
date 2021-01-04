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
    /// Represents the generated secondary_light_struct_block tag block.
    /// </summary>
    public sealed class SecondaryLightStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondaryLightStructBlock"/> class.
        /// </summary>
        public SecondaryLightStructBlock()
        {
            this.Fields.Add(new ExplanationField("Secondary light", ""));
            this.Fields.Add(new RealRgbColorField("Min lightmap color"));
            this.Fields.Add(new RealRgbColorField("Max lightmap color"));
            this.Fields.Add(new RealRgbColorField("Min diffuse sample"));
            this.Fields.Add(new RealRgbColorField("Max diffuse sample"));
            this.Fields.Add(new RealField("z axis rotation#degrees"));
            this.Fields.Add(new ExplanationField("Secondary light function", "input: accuracy, output: secondary light scale"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("function"));
        }
        /// <summary>
        /// Gets and returns the name of the secondary_light_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "secondary_light_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the secondary_light_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "secondary_light_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the secondary_light_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the secondary_light_struct_block tag block.
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
