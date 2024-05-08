using System;
using System.Windows.Forms;

namespace NotepadMDI
{
    partial class MainForm
    {
        private void arrangeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            findForm.Editor = ((Blank)ActiveMdiChild)?.RichTextBox;
            findForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank?.Delete();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank?.SelectAll();
        }

        private void New_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            SaveOrSaveAs(blank.WasSaved);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank?.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank?.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank?.Paste();
        }

        private void leftAlignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank.TextAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank.TextAlignment = HorizontalAlignment.Center;
        }

        private void rightAlignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank.TextAlignment = HorizontalAlignment.Right;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFontDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowColorDialog();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("uk");
        }

        private void exitToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Close();
        }
    }
}