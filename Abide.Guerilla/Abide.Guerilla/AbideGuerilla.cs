﻿using Abide.Decompiler;
using Abide.Guerilla.Dialogs;
using Abide.Guerilla.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Abide.Guerilla
{
    public partial class AbideGuerilla : Form
    {
        private Dictionary<string, TagGroupFileEditor> openEditors = new Dictionary<string, TagGroupFileEditor>();

        public AbideGuerilla()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }

        private void decompilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initialize CacheDecompiler instance...
            using (CacheDecompiler decompiler = new CacheDecompiler() { Icon = Properties.Resources.abide_icon, StartPosition = FormStartPosition.CenterParent })
                decompiler.ShowDialog();    //Show
        }

        private void compilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initialize CaceCompiler instance...
            using (CacheCompilerDialog compiler = new CacheCompilerDialog())
                compiler.ShowDialog();  //Show
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prepare
            AbideTagGroupFile file = null;

            //Initialize
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                //Setup
                openDlg.Filter = "All files (*.*)|*.*";
                openDlg.CustomPlaces.Add(new FileDialogCustomPlace(RegistrySettings.WorkspaceDirectory));

                //Show
                if (openDlg.ShowDialog() == DialogResult.OK)
                {

                    //Check
                    if (openEditors.ContainsKey(openDlg.FileName))
                        openEditors[openDlg.FileName].Show();
#if DEBUG
                    //Load file
                    file = new AbideTagGroupFile();
                    file.Load(openDlg.FileName);
#else
                    try
                    {
                        using (Stream stream = openDlg.OpenFile())
                        {
                            //Load file
                            file = new AbideTagGroupFile();
                            file.Load(stream);
                        }
                    }
                    catch { file = null; MessageBox.Show($"An error occured while opening {openDlg.FileName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); } 
#endif

                    //Check
                    if (file != null)
                    {
                        //Create editor
                        TagGroupFileEditor editor = new TagGroupFileEditor(openDlg.FileName, file) { MdiParent = this };
                        editor.FileNameChanged += Editor_FileNameChanged;
                        editor.FormClosed += Editor_FormClosed;
                        
                        //Show
                        editor.Show();
                    }
                }
            }
        }
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create dialog
            using (NewTagGroupDialog groupDialog = new NewTagGroupDialog())
            {
                //Show
                if(groupDialog.ShowDialog() == DialogResult.OK)
                {
                    //Create file
                    AbideTagGroupFile file = new AbideTagGroupFile() { TagGroup = groupDialog.SelectedGroup };

                    //Get name
                    string tagName = "tag"; int tagIndex = 1;
                    while (openEditors.ContainsKey($"{tagName}{tagIndex}")) tagIndex++;
                    
                    //Create editor
                    TagGroupFileEditor editor = new TagGroupFileEditor($"{tagName}{tagIndex}.{file.TagGroup.GroupName}", file) { MdiParent = this };
                    editor.FileNameChanged += Editor_FileNameChanged;
                    editor.FormClosed += Editor_FormClosed;
                    
                    //Show
                    editor.Show();
                }
            }
        }

        private void Editor_FileNameChanged(object sender, EventArgs e)
        {
            //Clear
            openEditors.Clear();

            //Loop
            foreach (Form child in MdiChildren)
                if (child is TagGroupFileEditor editor)
                    openEditors.Add(editor.FileName, editor);
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Prepare
            TagGroupFileEditor editor = null;

            //Get form
            if (sender is TagGroupFileEditor)
            {
                editor = (TagGroupFileEditor)sender;
                openEditors.Remove(editor.FileName);
            }
            else
            {
                //Clear
                openEditors.Clear();

                //Loop
                foreach (Form child in MdiChildren)
                    if (child is TagGroupFileEditor)
                    {
                        editor = (TagGroupFileEditor)child;
                        openEditors.Add(editor.FileName, editor);
                    }
            }
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initialize StartupScreen instance...
            using (StartupScreen startup = new StartupScreen())
            startup.ShowDialog();   //Show
        }

        private void generateEntPluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initialize
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                //Setup
                folderDlg.Description = "Browse to directory to create *.ent files.";

                //Show
                if (folderDlg.ShowDialog() == DialogResult.OK)
                {
                    foreach(var tag in Tags.GetExportedTagGroups())
                    {
                        //Get tag group
                        var tagGroup = Abide.Tag.Cache.Generated.TagLookup.CreateTagGroup(tag);

                        //Prepare
                        XmlWriterSettings settings = new XmlWriterSettings()
                        {
                            Indent = true,
                            NewLineOnAttributes = false,
                            IndentChars = "\t"
                        };

                        //Get file path
                        string tagName = tag.FourCc.Replace('<', '_').Replace('>', '_').Replace('?', '_').Replace('*', '_').Replace(' ', '_').Replace('\\', '_').Replace('/', '_');
                        string path = Path.Combine(folderDlg.SelectedPath, $"{tagName}.ent");

                        //Delete file
                        if (File.Exists(path)) File.Delete(path);

                        //Create stream
                        using (FileStream fs = File.OpenWrite(path))
                        using (XmlWriter writer = XmlWriter.Create(fs, settings))
                        {
                            //Write start document
                            writer.WriteStartDocument();

                            //Write plugin element
                            writer.WriteStartElement("plugin");

                            //Write attributes
                            writer.WriteStartAttribute("class");
                            writer.WriteValue(tag.FourCc);
                            writer.WriteEndAttribute();

                            writer.WriteStartAttribute("author");
                            writer.WriteValue("Abide");
                            writer.WriteEndAttribute();

                            writer.WriteStartAttribute("version");
                            writer.WriteValue("0.1");
                            writer.WriteEndAttribute();

                            int headerSize = 0;
                            foreach (var tagBlock in tagGroup)
                                headerSize += tagBlock.Size;

                            writer.WriteStartAttribute("headersize");
                            writer.WriteValue(headerSize);
                            writer.WriteEndAttribute();

                            //Write tag blocks
                            Action<Tag.ITagBlock> writeTagBlock = new Action<Tag.ITagBlock>((tagBlock) =>
                            {
                                int offset = 0;
                                foreach (var field in tagBlock)
                                {
                                    switch (field.Type)
                                    {
                                        case Abide.Tag.FieldType.FieldBlock:
                                            writer.WriteStartElement("struct");

                                            writer.WriteStartAttribute("name");
                                            writer.WriteValue(field.Name);
                                            writer.WriteEndAttribute();

                                            writer.WriteStartAttribute("offset");
                                            writer.WriteValue(offset);
                                            writer.WriteEndAttribute();

                                            writer.WriteStartAttribute("visible");
                                            writer.WriteValue(true);
                                            writer.WriteEndAttribute();

                                            var blockFieldTagBlock = ((Tag.BlockField)field).Create();
                                            writer.WriteStartAttribute("maxelementcount");
                                            writer.WriteValue(blockFieldTagBlock.MaximumElementCount);
                                            writer.WriteEndAttribute();

                                            writer.WriteStartAttribute("padalign");
                                            writer.WriteValue(blockFieldTagBlock.Alignment);
                                            writer.WriteEndAttribute();


                                            writer.WriteEndElement();
                                            break;

                                        case Abide.Tag.FieldType.FieldStruct:
                                            break;

                                        case Abide.Tag.FieldType.FieldStringId:
                                        case Abide.Tag.FieldType.FieldOldStringId:
                                            break;

                                        case Abide.Tag.FieldType.FieldString:
                                            break;

                                        case Abide.Tag.FieldType.FieldLongString:
                                            break;
                                        
                                        case Abide.Tag.FieldType.FieldCharInteger:
                                        case Abide.Tag.FieldType.FieldCharBlockIndex1:
                                        case Abide.Tag.FieldType.FieldCharBlockIndex2:
                                            break;

                                        case Abide.Tag.FieldType.FieldShortInteger:
                                        case Abide.Tag.FieldType.FieldShortBlockIndex1:
                                        case Abide.Tag.FieldType.FieldShortBlockIndex2:
                                            break;

                                        case Abide.Tag.FieldType.FieldLongInteger:
                                        case Abide.Tag.FieldType.FieldLongBlockIndex1:
                                        case Abide.Tag.FieldType.FieldLongBlockIndex2:
                                            break;

                                        case Abide.Tag.FieldType.FieldAngle:
                                        case Abide.Tag.FieldType.FieldReal:
                                        case Abide.Tag.FieldType.FieldRealFraction:
                                            break;

                                        case Abide.Tag.FieldType.FieldTag:
                                            break;

                                        case Abide.Tag.FieldType.FieldTagReference:
                                            break;
                                        
                                        case Abide.Tag.FieldType.FieldCharEnum:
                                            break;
                                        case Abide.Tag.FieldType.FieldEnum:
                                            break;
                                        case Abide.Tag.FieldType.FieldLongEnum:
                                            break;

                                        case Abide.Tag.FieldType.FieldLongFlags:
                                            break;
                                        case Abide.Tag.FieldType.FieldWordFlags:
                                            break;
                                        case Abide.Tag.FieldType.FieldByteFlags:
                                            break;

                                        case Abide.Tag.FieldType.FieldPoint2D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRectangle2D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRgbColor:
                                            break;

                                        case Abide.Tag.FieldType.FieldArgbColor:
                                            break;
                                        
                                        case Abide.Tag.FieldType.FieldRealPoint2D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealPoint3D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealVector2D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealVector3D:
                                            break;

                                        case Abide.Tag.FieldType.FieldQuaternion:
                                            break;

                                        case Abide.Tag.FieldType.FieldEulerAngles2D:
                                            break;

                                        case Abide.Tag.FieldType.FieldEulerAngles3D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealPlane2D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealPlane3D:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealRgbColor:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealArgbColor:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealHsvColor:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealAhsvColor:
                                            break;

                                        case Abide.Tag.FieldType.FieldShortBounds:
                                            break;

                                        case Abide.Tag.FieldType.FieldAngleBounds:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealBounds:
                                            break;

                                        case Abide.Tag.FieldType.FieldRealFractionBounds:
                                            break;
                                        

                                        
                                        case Abide.Tag.FieldType.FieldData:
                                            break;

                                        case Abide.Tag.FieldType.FieldVertexBuffer:
                                            break;
                                        
                                        case Abide.Tag.FieldType.FieldSkip:
                                        case Abide.Tag.FieldType.FieldPad:
                                            break;

                                        case Abide.Tag.FieldType.FieldTagIndex:
                                            break;

                                        case Abide.Tag.FieldType.FieldUselessPad:
                                            break;
                                        case Abide.Tag.FieldType.FieldLongBlockFlags:
                                            break;
                                        case Abide.Tag.FieldType.FieldWordBlockFlags:
                                            break;
                                        case Abide.Tag.FieldType.FieldByteBlockFlags:
                                            break;
                                    }

                                    offset += field.Size;
                                }
                            });

                            //Loop
                            foreach (var tagBlock in tagGroup)
                                writeTagBlock.Invoke(tagBlock);

                            //Write end plugin element
                            writer.WriteEndElement();

                            //End document
                            writer.WriteEndDocument();
                            fs.Flush();
                        }
                    }
                }
            }
        }
    }
}
