using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class Blank : Form
    {
        public string DocName { get; set; }
        public string BufferText = "";
        public bool IsSaved = false;
        public bool WasSaved = false;

        public Font TextFont
        {
            get => richTextBox.SelectionFont;
            set => richTextBox.SelectionFont = value;
        }

        public Color TextColor
        {
            get => richTextBox.SelectionColor;
            set => richTextBox.SelectionColor = value;
        }

        public RichTextBox RichTextBox
        {
            get => richTextBox;
            set => richTextBox = value;
        }

        public Blank()
        {
            InitializeComponent();
            sbTime.Text = DateTime.Now.ToLongTimeString();
            sbTime.ToolTipText = DateTime.Today.ToLongDateString();
        }

        public void Cut()
        {
            BufferText = richTextBox.SelectedText;
            richTextBox.SelectedText = "";
        }

        public void Copy()
        {
            BufferText = richTextBox.SelectedText;
        }

        public void Paste()
        {
            richTextBox.SelectedText = BufferText;
        }

        public void SelectAll()
        {
            richTextBox.SelectAll();
        }

        public void Delete()
        {
            richTextBox.SelectedText = "";
        }

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

        public void Open(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return;

            StreamReader reader = new StreamReader(fileName);
            richTextBox.Text = reader.ReadToEnd();
            reader.Close();
        }

        public void Save(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return;

            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(richTextBox.Text);
            writer.Close();
        }

        private void Blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = $"Do you want to save changes in {DocName}?";
            if (!IsSaved && MessageBox.Show(message, "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (WasSaved)
                {
                    ((MainForm) MdiParent).Save();
                }
                else
                {
                    ((MainForm) MdiParent).SaveAs();
                }
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshAmount();
        }

        public void RefreshAmount()
        {
            sbAmount.Text = $"Amount of symbols {richTextBox.Text.Length}";
        }

        private void Blank_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!WasSaved)
            {
                ((MainForm) MdiParent).SetFreeUntitledNum(DocName);
            }
        }
    }
}