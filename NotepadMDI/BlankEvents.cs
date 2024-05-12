using System;
using System.Windows.Forms;

namespace NotepadMDI
{
    partial class Blank
    {
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshAmount();
            Highlighter.Highlight();
        }

        private void Blank_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!WasSaved)
            {
                MainForm mainForm = (MainForm)MdiParent;
                mainForm.SetFreeUntitledNum(DocName);
            }
        }

        private void Blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DefineIfNeedsToSave())
            {
                MainForm mainForm = (MainForm)MdiParent;
                mainForm.SaveOrSaveAs(WasSaved);
            }
        }
    }
}