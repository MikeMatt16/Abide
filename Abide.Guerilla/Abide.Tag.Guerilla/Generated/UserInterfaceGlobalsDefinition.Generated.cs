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
    /// Represents the generated user_interface_globals_definition (wgtz) tag group.
    /// </summary>
    public class UserInterfaceGlobalsDefinition : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceGlobalsDefinition"/> class.
        /// </summary>
        public UserInterfaceGlobalsDefinition()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new UserInterfaceGlobalsDefinitionBlock());
        }
        /// <summary>
        /// Gets and returns the name of the user_interface_globals_definition tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "user_interface_globals_definition";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the user_interface_globals_definition tag group.
        /// </summary>
        public override TagFourCc Tag
        {
            get
            {
                return "wgtz";
            }
        }
    }
}
