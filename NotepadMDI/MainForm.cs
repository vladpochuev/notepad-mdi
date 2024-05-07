using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class MainForm : Form
    {
        private HashSet<int> UntitledNums = new HashSet<int>();

        public int GetFreeUntitledNum()
        {
            int i;
            for (i = 1; i < UntitledNums.Count + 1; i++)
            {
                if (!UntitledNums.Contains(i))
                {
                    break;
                }
            }

            UntitledNums.Add(i);
            return i;
        }

        public void SetFreeUntitledNum(string docName)
        {
            string[] splitDocName = docName.Split(' ');
            int num = Convert.ToInt32(splitDocName[splitDocName.Length - 1]);
            UntitledNums.Remove(num);
        }

        public MainForm()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
        }

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

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            frm.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            frm.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            frm.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            frm.Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            frm.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = new Blank();
            frm.DocName = "Untitled " + GetFreeUntitledNum();
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.RefreshAmount();
            frm.Show();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank frm = new Blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.WasSaved = true;
                frm.RefreshAmount();
                frm.Show();
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        public void Save()
        {
            Blank frm = (Blank)ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        public void SaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank frm = (Blank)ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                if (!frm.WasSaved)
                {
                    SetFreeUntitledNum(frm.DocName);
                }
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = saveFileDialog1.FileName;
                saveToolStripMenuItem.Enabled = true;
                frm.WasSaved = true;
                frm.IsSaved = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            fontDialog1.ShowColor = false;
            fontDialog1.Font = frm.TextFont;
            fontDialog1.Color = frm.TextColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.TextFont = fontDialog1.Font;
                frm.TextColor = fontDialog1.Color;
            }

            frm.Show();
        }


        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)ActiveMdiChild;
            colorDialog1.Color = frm.TextColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.TextColor = colorDialog1.Color;
            }

            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            findForm.Editor = ((Blank)ActiveMdiChild)?.RichTextBox;
            findForm.Show();
        }

        private void toolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals(tbNew))
            {
                newToolStripMenuItem_Click(this, EventArgs.Empty);
            }

            if (e.ClickedItem.Equals(tbOpen))
            {
                openToolStripMenuItem_Click(this, EventArgs.Empty);
            }

            if (e.ClickedItem.Equals(tbSave))
            {
                if (((Blank)ActiveMdiChild).WasSaved)
                {
                    Save();
                }
                else
                {
                    SaveAs();
                }
            }

            if (e.ClickedItem.Equals(tbCut))
            {
                cutToolStripMenuItem_Click(this, EventArgs.Empty);
            }

            if (e.ClickedItem.Equals(tbCopy))
            {
                copyToolStripMenuItem_Click(this, EventArgs.Empty);
            }

            if (e.ClickedItem.Equals(tbPaste))
            {
                pasteToolStripMenuItem_Click(this, EventArgs.Empty);
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Controls.Remove(miniToolStrip);
            Controls.Remove(toolStripMain);
            InitializeComponent();
            foreach (var mdiChild in MdiChildren)
            {
                ((Blank)mdiChild).RefreshAmount();
            }
            englishToolStripMenuItem.Checked = true;
            ukrainianToolStripMenuItem.Checked = false;
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk");
            Controls.Remove(miniToolStrip);
            Controls.Remove(toolStripMain);
            InitializeComponent();
            foreach (var mdiChild in MdiChildren)
            {
                ((Blank)mdiChild).RefreshAmount();
            }
            englishToolStripMenuItem.Checked = false;
            ukrainianToolStripMenuItem.Checked = true;
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }
    }
}