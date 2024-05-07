using System;
using System.Windows.Forms;

namespace NotepadMDI
{
    partial class FindForm
    {
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            btnFindNext.Enabled = txtFind.Text.Length > 0;
            UpdateSearchQuery();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}