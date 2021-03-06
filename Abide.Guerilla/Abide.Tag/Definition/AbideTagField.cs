﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Abide.Tag.Definition
{
    /// <summary>
    /// Represents an Abide tag field definition.
    /// </summary>
    public class AbideTagField : ICloneable
    {
        /// <summary>
        /// Gets or sets the full field name.
        /// </summary>
        public ObjectName NameObject
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
        /// <summary>
        /// Gets or sets the tag block referenced by this field.
        /// </summary>
        public AbideTagBlock ReferencedBlock
        {
            get { return referencedBlock; }
            set { referencedBlock = value; }
        }
        /// <summary>
        /// Gets and returns the options for this field.
        /// </summary>
        public List<ObjectName> Options
        {
            get { return options; }
        }
        /// <summary>
        /// Gets and returns the list of fields in the field.
        /// </summary>
        public List<AbideTagField> Fields
        {
            get { return fields; }
        }
        /// <summary>
        /// Gets or sets the group tag of the field.
        /// </summary>
        public int GroupTag
        {
            get { return groupTag; }
            set { groupTag = value; }
        }
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        public string Name
        {
            get { return fieldName.Name; }
            set { fieldName.Name = value; }
        }
        /// <summary>
        /// Gets or sets the field details.
        /// </summary>
        public string Details
        {
            get { return fieldName.Details; }
            set { fieldName.Details = value; }
        }
        /// <summary>
        /// Gets or sets the field tool tip.
        /// </summary>
        public string Information
        {
            get { return fieldName.Information; }
            set { fieldName.Information = value; }
        }
        /// <summary>
        /// Gets or sets whether this field the block it belongs to.
        /// </summary>
        public bool IsBlockName
        {
            get { return fieldName.IsBlockName; }
            set { fieldName.IsBlockName = value; }
        }
        /// <summary>
        /// Gets or sets whether this field is read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get { return fieldName.IsReadOnly; }
            set { fieldName.IsReadOnly = value; }
        }
        /// <summary>
        /// Gets or sets the field explanation.
        /// </summary>
        public string Explanation
        {
            get { return explanation; }
            set { explanation = value; }
        }
        /// <summary>
        /// Gets or sets the block field's block name.
        /// </summary>
        public string BlockName
        {
            get { return blockName; }
            set { blockName = value; }
        }
        /// <summary>
        /// Gets or sets the struct field's block name.
        /// </summary>
        public string StructName
        {
            get { return structName; }
            set { structName = value; }
        }
        /// <summary>
        /// Gets or sets the field type.
        /// </summary>
        public FieldType FieldType
        {
            get { return fieldType; }
            set { fieldType = value; }
        }
        /// <summary>
        /// Gets or sets the data alignment for this field.
        /// </summary>
        public int Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        /// <summary>
        /// Gets or sets the data maximum length for this data field.
        /// </summary>
        public int MaximumSize
        {
            get { return maximumSize; }
            set { maximumSize = value; }
        }
        /// <summary>
        /// Gets or sets the data maximum length for this data field.
        /// </summary>
        public int ElementSize
        {
            get { return elementSize; }
            set { elementSize = value; }
        }
        /// <summary>
        /// Gets or sets the length for this pad or skip field.
        /// </summary>
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        
        private readonly List<AbideTagField> fields;
        private readonly List<ObjectName> options;
        private FieldType fieldType;
        private string blockName, structName, explanation;
        private int alignment, maximumSize, elementSize, length, groupTag;
        private AbideTagBlock referencedBlock = null;
        private ObjectName fieldName;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AbideTagField"/> class.
        /// </summary>
        public AbideTagField()
        {
            //Prepare
            options = new List<ObjectName>();
            fields = new List<AbideTagField>();
            fieldName = new ObjectName(string.Empty);
        }
        /// <summary>
        /// Returns a copy of the <see cref="AbideTagField"/> object.
        /// </summary>
        /// <returns>A copy of the current <see cref="AbideTagField"/> object.</returns>
        public object Clone()
        {
            //Create field
            AbideTagField field = new AbideTagField()
            {
                fieldType = fieldType,
                fieldName = new ObjectName(fieldName.ToString()),
                blockName = blockName,
                structName = structName,
                alignment = alignment,
                maximumSize = maximumSize,
                elementSize = elementSize,
                length = length,
                referencedBlock = (AbideTagBlock)referencedBlock?.Clone() ?? null,
                explanation = explanation,
                groupTag = groupTag,
            };

            //Add children
            field.fields.AddRange(fields.Select(f => (AbideTagField)f.Clone()));
            field.options.AddRange(options.Select(o => new ObjectName(o.ToString())));

            //Return
            return field;
        }
        /// <summary>
        /// Returns a string representation of this <see cref="AbideTagField"/>.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return $"{fieldType} {fieldName.Name}";
        }
        /// <summary>
        /// Returns the full field name.
        /// </summary>
        /// <returns>A new <see cref="NameObject"/> instance.</returns>
        public ObjectName GetFullName()
        {
            //Return
            return new ObjectName(fieldName.ToString());
        }
        /// <summary>
        /// Saves the Abide tag field definition to the specified <see cref="XmlWriter"/>.
        /// </summary>
        /// <param name="w">The <see cref="XmlWriter"/> to which you want to save.</param>
        internal void Save(XmlWriter w)
        {
            //Write name
            w.WriteStartAttribute("Name");
            w.WriteValue(fieldName.ToString());
            w.WriteEndAttribute();

            //Handle
            switch (fieldType)
            {
                case FieldType.FieldStruct:
                    //Write struct name
                    w.WriteStartAttribute("StructName");
                    w.WriteValue(structName);
                    w.WriteEndAttribute();
                    break;
                case FieldType.FieldBlock:
                    //Write block name
                    w.WriteStartAttribute("BlockName");
                    w.WriteValue(blockName);
                    w.WriteEndAttribute();
                    break;
                case FieldType.FieldData:
                    //Write alignment
                    w.WriteStartAttribute("Alignment");
                    w.WriteValue(alignment);
                    w.WriteEndAttribute();

                    //Write maximum size
                    w.WriteStartAttribute("MaximumSize");
                    w.WriteValue(maximumSize);
                    w.WriteEndAttribute();

                    //Write element size
                    w.WriteStartAttribute("ElementSize");
                    w.WriteValue(elementSize);
                    w.WriteEndAttribute();
                    break;
                case FieldType.FieldPad:
                    //Write length
                    w.WriteStartAttribute("Length");
                    w.WriteValue(length);
                    w.WriteEndAttribute();
                    break;
                case FieldType.FieldSkip:
                    //Write length
                    w.WriteStartAttribute("Length");
                    w.WriteValue(length);
                    w.WriteEndAttribute();
                    break;
                case FieldType.FieldExplanation:
                    //Write explanation
                    w.WriteStartAttribute("Explanation");
                    w.WriteValue(explanation.Replace("\n", "|n"));
                    w.WriteEndAttribute();
                    break;
                
            }
        }
        /// <summary>
        /// Returns an <see cref="AbideTagField"/> instance from a supplied <see cref="XmlNode"/>.
        /// </summary>
        /// <param name="xmlNode">The base XML node.</param>
        /// <returns>A <see cref="AbideTagField"/> instance.</returns>
        internal static AbideTagField FromXmlNode(XmlNode xmlNode)
        {
            //Prepare
            AbideTagField field = new AbideTagField();

            //Get Attributes
            field.fieldName = new ObjectName(xmlNode.Attributes["Name"]?.Value ?? string.Empty);
            field.explanation = xmlNode.Attributes["Explanation"]?.Value?.Replace("|n", "\n") ?? string.Empty;
            field.blockName = xmlNode.Attributes["BlockName"]?.Value ?? string.Empty;
            field.structName = xmlNode.Attributes["StructName"]?.Value ?? string.Empty;
            int.TryParse(xmlNode.Attributes["GroupTag"]?.Value, out field.groupTag);
            int.TryParse(xmlNode.Attributes["Alignment"]?.Value, out field.alignment);
            int.TryParse(xmlNode.Attributes["MaximumSize"]?.Value, out field.maximumSize);
            int.TryParse(xmlNode.Attributes["ElementSize"]?.Value, out field.elementSize);
            int.TryParse(xmlNode.Attributes["Length"]?.Value, out field.length);

            //Get Type
            if (!Enum.TryParse(xmlNode.Name, out field.fieldType)) throw new TagException($"Unable to parse field node's type. ({xmlNode.Name})");

            //Check
            switch (field.fieldType)
            {
                case FieldType.FieldArrayStart:
                    foreach (XmlNode fieldNode in xmlNode)
                        field.fields.Add(FromXmlNode(fieldNode));
                    break;
                case FieldType.FieldCharEnum:
                case FieldType.FieldEnum:
                case FieldType.FieldLongEnum:
                case FieldType.FieldLongFlags:
                case FieldType.FieldWordFlags:
                case FieldType.FieldByteFlags:
                case FieldType.FieldLongBlockFlags:
                case FieldType.FieldWordBlockFlags:
                case FieldType.FieldByteBlockFlags:
                    foreach (XmlNode optionNode in xmlNode)
                        field.options.Add(new ObjectName(optionNode.Attributes["Name"]?.Value ?? string.Empty));
                    break;
            }

            //Return
            return field;
        }
    }

    public struct ObjectName
    {
        private static readonly char[] breakChars = { ':', '#', '^', '*' };
        private string name, details, information;

        public string Name
        {
            get { return name ?? string.Empty; }
            set { name = value ?? string.Empty; }
        }
        public string Details
        {
            get { if (string.IsNullOrEmpty(details)) return null; return details?.Substring(1) ?? null; }
            set { details = value != null ? $":{value}" : null; }
        }
        public string Information
        {
            get { if (string.IsNullOrEmpty(information)) return null; return information?.Substring(1) ?? null; }
            set { information = value != null ? $"#{value}" : null; }
        }
        public bool IsBlockName { get; set; }
        public bool IsReadOnly { get; set; }
        
        public ObjectName(string str)
        {
            name = GetName(str);
            details = GetDetails(str);
            information = GetInformation(str);
            IsBlockName = GetIsBlockName(str);
            IsReadOnly = GetIsReadonly(str);
        }
        private static string GetName(string name)
        {
            int startIndex = 0;
            if (startIndex < 0) return null;
            else if (startIndex >= name.Length) return null;

            int endIndex = name.IndexOfAny(breakChars, startIndex);
            int length;
            if (endIndex < 0) length = name.Length - startIndex; else length = endIndex - startIndex;
            return name.Substring(startIndex, length);
        }
        private static string GetDetails(string name)
        {
            int startIndex = name.IndexOf(':');
            if (startIndex < 0) return null;
            else if (startIndex >= name.Length) return null;

            int endIndex = name.IndexOfAny(breakChars, startIndex + 1);
            int length;
            if (endIndex < 0) length = name.Length - startIndex; else length = endIndex - startIndex;
            return name.Substring(startIndex, length);
        }
        private static string GetInformation(string name)
        {
            int startIndex = name.IndexOf('#');
            if (startIndex < 0) return null;
            else if (startIndex >= name.Length) return null;

            int endIndex = name.IndexOfAny(breakChars, startIndex + 1);
            int length;
            if (endIndex < 0) length = name.Length - startIndex; else length = endIndex - startIndex;
            return name.Substring(startIndex, length);
        }
        private static bool GetIsBlockName(string name)
        {
            return name.Contains("^");
        }
        private static bool GetIsReadonly(string name)
        {
            return name.Contains("*");
        }
        public override bool Equals(object obj)
        {
            if (obj is ObjectName objName)
            {
                if (name.Equals(objName.name) && details.Equals(objName.details) && information.Equals(objName.information) &&
                    IsBlockName.Equals(objName.IsBlockName) && IsReadOnly.Equals(objName.IsReadOnly))
                {
                    return true;
                }
            }
            else if (obj is string str)
            {
                return Equals(new ObjectName(str));
            }

            return false;
        }
        public override string ToString()
        {
            var name = $"{Name}{(IsReadOnly ? "*" : string.Empty)}{(IsBlockName ? "^" : string.Empty)}";
            if (!string.IsNullOrEmpty(Details))
            {
                name += $":{Details}";
            }
            if (!string.IsNullOrEmpty(Information))
            {
                name += $"#{Information}";
            }
            return name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ details.GetHashCode() ^ information.GetHashCode() ^ IsBlockName.GetHashCode() ^ IsReadOnly.GetHashCode();
        }

        public static bool operator ==(ObjectName left, ObjectName right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(ObjectName left, ObjectName right)
        {
            return !(left == right);
        }
    }
}
