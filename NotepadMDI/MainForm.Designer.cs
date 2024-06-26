﻿namespace NotepadMDI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.leftAlignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tbNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbLAlignment = new System.Windows.Forms.ToolStripButton();
            this.tbCAlignment = new System.Windows.Forms.ToolStripButton();
            this.tbRAlignment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFont = new System.Windows.Forms.ToolStripButton();
            this.tbColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tbImage = new System.Windows.Forms.ToolStripButton();
            this.tbCode = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            resources.ApplyResources(this.miniToolStrip, "miniToolStrip");
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.formatToolStripMenuItem, this.windowToolStripMenuItem, this.languageToolStripMenuItem });
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.TabStop = true;
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newToolStripMenuItem, this.openToolStripMenuItem, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator2, this.findToolStripMenuItem, this.toolStripSeparator3, this.exitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.New_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // findToolStripMenuItem
            // 
            resources.ApplyResources(this.findToolStripMenuItem, "findToolStripMenuItem");
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.Find_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem, this.toolStripSeparator1, this.deleteToolStripMenuItem, this.selectAllToolStripMenuItem });
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            // 
            // cutToolStripMenuItem
            // 
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // formatToolStripMenuItem
            // 
            resources.ApplyResources(this.formatToolStripMenuItem, "formatToolStripMenuItem");
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fontToolStripMenuItem, this.colorToolStripMenuItem, this.insertImageToolStripMenuItem, this.toolStripMenuItem1, this.leftAlignmentToolStripMenuItem, this.centerAlignmentToolStripMenuItem, this.rightAlignmentToolStripMenuItem });
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            // 
            // fontToolStripMenuItem
            // 
            resources.ApplyResources(this.fontToolStripMenuItem, "fontToolStripMenuItem");
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            resources.ApplyResources(this.colorToolStripMenuItem, "colorToolStripMenuItem");
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // insertImageToolStripMenuItem
            // 
            resources.ApplyResources(this.insertImageToolStripMenuItem, "insertImageToolStripMenuItem");
            this.insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
            this.insertImageToolStripMenuItem.Click += new System.EventHandler(this.insertImageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // leftAlignmentToolStripMenuItem
            // 
            resources.ApplyResources(this.leftAlignmentToolStripMenuItem, "leftAlignmentToolStripMenuItem");
            this.leftAlignmentToolStripMenuItem.Name = "leftAlignmentToolStripMenuItem";
            this.leftAlignmentToolStripMenuItem.Click += new System.EventHandler(this.leftAlignmentToolStripMenuItem_Click);
            // 
            // centerAlignmentToolStripMenuItem
            // 
            resources.ApplyResources(this.centerAlignmentToolStripMenuItem, "centerAlignmentToolStripMenuItem");
            this.centerAlignmentToolStripMenuItem.Name = "centerAlignmentToolStripMenuItem";
            this.centerAlignmentToolStripMenuItem.Click += new System.EventHandler(this.centerAlignmentToolStripMenuItem_Click);
            // 
            // rightAlignmentToolStripMenuItem
            // 
            resources.ApplyResources(this.rightAlignmentToolStripMenuItem, "rightAlignmentToolStripMenuItem");
            this.rightAlignmentToolStripMenuItem.Name = "rightAlignmentToolStripMenuItem";
            this.rightAlignmentToolStripMenuItem.Click += new System.EventHandler(this.rightAlignmentToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.arrangeItemsToolStripMenuItem, this.cascadeToolStripMenuItem, this.horizontalToolStripMenuItem, this.tileVerticalToolStripMenuItem });
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            // 
            // arrangeItemsToolStripMenuItem
            // 
            resources.ApplyResources(this.arrangeItemsToolStripMenuItem, "arrangeItemsToolStripMenuItem");
            this.arrangeItemsToolStripMenuItem.Name = "arrangeItemsToolStripMenuItem";
            this.arrangeItemsToolStripMenuItem.Click += new System.EventHandler(this.arrangeItemsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            resources.ApplyResources(this.cascadeToolStripMenuItem, "cascadeToolStripMenuItem");
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            resources.ApplyResources(this.horizontalToolStripMenuItem, "horizontalToolStripMenuItem");
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            resources.ApplyResources(this.tileVerticalToolStripMenuItem, "tileVerticalToolStripMenuItem");
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.englishToolStripMenuItem, this.ukrainianToolStripMenuItem });
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // ukrainianToolStripMenuItem
            // 
            resources.ApplyResources(this.ukrainianToolStripMenuItem, "ukrainianToolStripMenuItem");
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.ukrainianToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.rtf";
            this.openFileDialog.FileName = "Text Files";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.rtf";
            this.saveFileDialog.FileName = "Text Files";
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // toolStripMain
            // 
            resources.ApplyResources(this.toolStripMain, "toolStripMain");
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tbNew, this.tbOpen, this.tbSave, this.toolStripSeparator4, this.tbCut, this.tbCopy, this.tbPaste, this.toolStripSeparator5, this.tbLAlignment, this.tbCAlignment, this.tbRAlignment, this.toolStripSeparator6, this.tbFont, this.tbColor, this.toolStripSeparator7, this.tbImage, this.tbCode });
            this.toolStripMain.Name = "toolStripMain";
            // 
            // tbNew
            // 
            resources.ApplyResources(this.tbNew, "tbNew");
            this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNew.Name = "tbNew";
            this.tbNew.Click += new System.EventHandler(this.New_Click);
            // 
            // tbOpen
            // 
            resources.ApplyResources(this.tbOpen, "tbOpen");
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // tbSave
            // 
            resources.ApplyResources(this.tbSave, "tbSave");
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Name = "tbSave";
            this.tbSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // tbCut
            // 
            resources.ApplyResources(this.tbCut, "tbCut");
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Name = "tbCut";
            this.tbCut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // tbCopy
            // 
            resources.ApplyResources(this.tbCopy, "tbCopy");
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // tbPaste
            // 
            resources.ApplyResources(this.tbPaste, "tbPaste");
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // tbLAlignment
            // 
            resources.ApplyResources(this.tbLAlignment, "tbLAlignment");
            this.tbLAlignment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLAlignment.Image = global::NotepadMDI.Properties.Resources.left_alignment_icon;
            this.tbLAlignment.Name = "tbLAlignment";
            this.tbLAlignment.Click += new System.EventHandler(this.leftAlignmentToolStripMenuItem_Click);
            // 
            // tbCAlignment
            // 
            resources.ApplyResources(this.tbCAlignment, "tbCAlignment");
            this.tbCAlignment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCAlignment.Image = global::NotepadMDI.Properties.Resources.center_alignment_icon;
            this.tbCAlignment.Name = "tbCAlignment";
            this.tbCAlignment.Click += new System.EventHandler(this.centerAlignmentToolStripMenuItem_Click);
            // 
            // tbRAlignment
            // 
            resources.ApplyResources(this.tbRAlignment, "tbRAlignment");
            this.tbRAlignment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRAlignment.Image = global::NotepadMDI.Properties.Resources.right_alignment_icon;
            this.tbRAlignment.Name = "tbRAlignment";
            this.tbRAlignment.Click += new System.EventHandler(this.rightAlignmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // tbFont
            // 
            resources.ApplyResources(this.tbFont, "tbFont");
            this.tbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFont.Image = global::NotepadMDI.Properties.Resources.font_icon;
            this.tbFont.Name = "tbFont";
            this.tbFont.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // tbColor
            // 
            resources.ApplyResources(this.tbColor, "tbColor");
            this.tbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbColor.Image = global::NotepadMDI.Properties.Resources.color_icon;
            this.tbColor.Name = "tbColor";
            this.tbColor.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // tbImage
            // 
            resources.ApplyResources(this.tbImage, "tbImage");
            this.tbImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbImage.Image = global::NotepadMDI.Properties.Resources.image_icon;
            this.tbImage.Name = "tbImage";
            this.tbImage.Click += new System.EventHandler(this.insertImageToolStripMenuItem_Click);
            // 
            // tbCode
            // 
            resources.ApplyResources(this.tbCode, "tbCode");
            this.tbCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCode.Image = global::NotepadMDI.Properties.Resources.code_icon;
            this.tbCode.Name = "tbCode";
            this.tbCode.Click += new System.EventHandler(this.tbCode_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.miniToolStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

        private System.Windows.Forms.ToolStripButton tbCode;

        private System.Windows.Forms.ToolStripButton tbColor;

        private System.Windows.Forms.ToolStripButton tbFont;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.ToolStripButton tbRAlignment;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem centerAlignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightAlignmentToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem leftAlignmentToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton tbPaste;

        private System.Windows.Forms.ToolStripButton tbNew;

        private System.Windows.Forms.ToolStripButton tbOpen;

        private System.Windows.Forms.ToolStripButton tbCopy;

        private System.Windows.Forms.ToolStripButton tbCut;

        private System.Windows.Forms.ToolStripButton tbSave;

        private System.Windows.Forms.ToolStripButton tbLAlignment;

        private System.Windows.Forms.ToolStripButton tbCAlignment;

        private System.Windows.Forms.ToolStripButton tbImage;

        private System.Windows.Forms.ToolStrip toolStripMain;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;

        private System.Windows.Forms.ColorDialog colorDialog;

        private System.Windows.Forms.FontDialog fontDialog1;

        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;

        private System.Windows.Forms.MenuStrip miniToolStrip;

        #endregion
    }
}