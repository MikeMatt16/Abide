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
    /// Represents the generated object_function_block tag block.
    /// </summary>
    public sealed class ObjectFunctionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFunctionBlock"/> class.
        /// </summary>
        public ObjectFunctionBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "invert#result of function is one minus actual result", "mapping does not controls active#the curve mapping can make the function active/i" +
                        "nactive", "always active#function does not deactivate when at or below lower bound", "random time offset#function offsets periodic function input by random value betwe" +
                        "en 0 and 1"));
            this.Fields.Add(new StringIdField("import name"));
            this.Fields.Add(new StringIdField("export name"));
            this.Fields.Add(new StringIdField("turn off with#if the specified function is off, so is this function"));
            this.Fields.Add(new RealField("min value#function must exceed this value (after mapping) to be active 0. means d" +
                        "o nothing"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("default function"));
            this.Fields.Add(new StringIdField("scale by"));
        }
        /// <summary>
        /// Gets and returns the name of the object_function_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "object_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_function_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_function_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_function_block tag block.
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
