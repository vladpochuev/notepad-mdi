using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class Blank : Form
    {
        public string DocName { get; set; }
        public bool IsSaved = false;
        public bool WasSaved = false;
        private string BufferText { get; set; }
        private ComponentResourceManager Resources { get; set; }

        public Font TextFont
        {
            get => RichTextBox.SelectionFont;
            set => RichTextBox.SelectionFont = value;
        }

        public Color TextColor
        {
            get => RichTextBox.SelectionColor;
            set => RichTextBox.SelectionColor = value;
        }

        public RichTextBox RichTextBox
        {
            get => richTextBox;
            set => richTextBox = value;
        }

        public Blank()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            Resources = new ComponentResourceManager(typeof(Blank));
            BufferText = "";
            SetTimeNow();
        }

        private void SetTimeNow()
        {
            sbTime.Text = DateTime.Now.ToLongTimeString();
            sbTime.ToolTipText = DateTime.Today.ToLongDateString();
        }

        public void Cut()
        {
            BufferText = RichTextBox.SelectedText;
            RichTextBox.SelectedText = "";
        }

        public void Copy()
        {
            BufferText = RichTextBox.SelectedText;
        }

        public void Paste()
        {
            RichTextBox.SelectedText = BufferText;
        }

        public void Delete()
        {
            RichTextBox.SelectedText = "";
        }

        public void SelectAll()
        {
            RichTextBox.SelectAll();
        }

        public void ReadFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return;
            StreamReader reader = new StreamReader(fileName);
            RichTextBox.Text = reader.ReadToEnd();
            reader.Close();
        }

        public void WriteFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return;
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(RichTextBox.Text);
            writer.Close();
        }

        private void ShowSaveDialog(string title, string message)
        {
            if (!IsSaved && MessageBox.Show(string.Format(message, DocName),
                    title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainForm mainForm = (MainForm)MdiParent;
                mainForm.SaveOrSaveAs(WasSaved);
            }
        }

        public void RefreshAmount()
        {
            sbAmount.Text = Resources.GetString("blank_amount_of_symbols") + RichTextBox.Text.Length;
        }
    }
}