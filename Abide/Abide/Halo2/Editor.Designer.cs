﻿namespace Abide.Halo2
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.tagPanel = new System.Windows.Forms.Panel();
            this.tagSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tagTree = new System.Windows.Forms.TreeView();
            this.tagImageList = new System.Windows.Forms.ImageList(this.components);
            this.tagTabControl = new System.Windows.Forms.TabControl();
            this.tagPropertiesTabPage = new System.Windows.Forms.TabPage();
            this.tagPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.tagPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagSplitContainer)).BeginInit();
            this.tagSplitContainer.Panel1.SuspendLayout();
            this.tagSplitContainer.Panel2.SuspendLayout();
            this.tagSplitContainer.SuspendLayout();
            this.tagTabControl.SuspendLayout();
            this.tagPropertiesTabPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagPanel
            // 
            this.tagPanel.Controls.Add(this.tagSplitContainer);
            this.tagPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tagPanel.Location = new System.Drawing.Point(0, 0);
            this.tagPanel.Name = "tagPanel";
            this.tagPanel.Size = new System.Drawing.Size(260, 511);
            this.tagPanel.TabIndex = 0;
            // 
            // tagSplitContainer
            // 
            this.tagSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.tagSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tagSplitContainer.Name = "tagSplitContainer";
            this.tagSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tagSplitContainer.Panel1
            // 
            this.tagSplitContainer.Panel1.Controls.Add(this.tagTree);
            // 
            // tagSplitContainer.Panel2
            // 
            this.tagSplitContainer.Panel2.Controls.Add(this.tagTabControl);
            this.tagSplitContainer.Size = new System.Drawing.Size(260, 511);
            this.tagSplitContainer.SplitterDistance = 250;
            this.tagSplitContainer.TabIndex = 0;
            // 
            // tagTree
            // 
            this.tagTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagTree.ImageIndex = 0;
            this.tagTree.ImageList = this.tagImageList;
            this.tagTree.Location = new System.Drawing.Point(0, 0);
            this.tagTree.Name = "tagTree";
            this.tagTree.SelectedImageIndex = 0;
            this.tagTree.Size = new System.Drawing.Size(260, 250);
            this.tagTree.TabIndex = 0;
            this.tagTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tagTree_AfterSelect);
            // 
            // tagImageList
            // 
            this.tagImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tagImageList.ImageStream")));
            this.tagImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tagImageList.Images.SetKeyName(0, "Folder16.png");
            this.tagImageList.Images.SetKeyName(1, "Abide Reference.png");
            // 
            // tagTabControl
            // 
            this.tagTabControl.Controls.Add(this.tagPropertiesTabPage);
            this.tagTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagTabControl.Location = new System.Drawing.Point(0, 0);
            this.tagTabControl.Name = "tagTabControl";
            this.tagTabControl.SelectedIndex = 0;
            this.tagTabControl.Size = new System.Drawing.Size(260, 257);
            this.tagTabControl.TabIndex = 0;
            // 
            // tagPropertiesTabPage
            // 
            this.tagPropertiesTabPage.Controls.Add(this.tagPropertyGrid);
            this.tagPropertiesTabPage.Location = new System.Drawing.Point(4, 22);
            this.tagPropertiesTabPage.Name = "tagPropertiesTabPage";
            this.tagPropertiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tagPropertiesTabPage.Size = new System.Drawing.Size(252, 231);
            this.tagPropertiesTabPage.TabIndex = 0;
            this.tagPropertiesTabPage.Text = "Properties";
            this.tagPropertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // tagPropertyGrid
            // 
            this.tagPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagPropertyGrid.HelpVisible = false;
            this.tagPropertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.tagPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.tagPropertyGrid.Name = "tagPropertyGrid";
            this.tagPropertyGrid.Size = new System.Drawing.Size(246, 225);
            this.tagPropertyGrid.TabIndex = 0;
            this.tagPropertyGrid.ToolbarVisible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(260, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 511);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(263, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.Image = global::Abide.Properties.Resources.Tools;
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(64, 22);
            this.toolStripDropDownButton.Text = "&Tools";
            // 
            // toolPanel
            // 
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolPanel.Location = new System.Drawing.Point(263, 25);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(521, 486);
            this.toolPanel.TabIndex = 3;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tagPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "Halo 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Halo2Editor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.tagPanel.ResumeLayout(false);
            this.tagSplitContainer.Panel1.ResumeLayout(false);
            this.tagSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagSplitContainer)).EndInit();
            this.tagSplitContainer.ResumeLayout(false);
            this.tagTabControl.ResumeLayout(false);
            this.tagPropertiesTabPage.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tagPanel;
        private System.Windows.Forms.SplitContainer tagSplitContainer;
        private System.Windows.Forms.TreeView tagTree;
        private System.Windows.Forms.TabControl tagTabControl;
        private System.Windows.Forms.TabPage tagPropertiesTabPage;
        private System.Windows.Forms.PropertyGrid tagPropertyGrid;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList tagImageList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.Panel toolPanel;
    }
}