using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class MainForm : Form
    {
        private HashSet<int> UntitledNums { get; set; }
        private ComponentResourceManager Resources { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            UntitledNums = new HashSet<int>();
            Resources = new ComponentResourceManager(typeof(MainForm));
        }

        private void Save()
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank.WriteFile(blank.DocName);
            blank.IsSaved = true;
        }

        private void SaveAs()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Blank blank = (Blank)ActiveMdiChild;
                blank.WriteFile(saveFileDialog.FileName);
                if (!blank.WasSaved) SetFreeUntitledNum(blank.DocName);

                blank.DocName = saveFileDialog.FileName;
                blank.Text = saveFileDialog.FileName;
                saveToolStripMenuItem.Enabled = true;
                blank.WasSaved = true;
                blank.IsSaved = true;
            }
        }

        private void Open()
        {
            SetOpenFileProperty();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            Blank blank = new Blank();
            blank.MdiParent = this;
            blank.DocName = openFileDialog.FileName;
            blank.Text = blank.DocName;
            blank.WasSaved = true;
            blank.ReadFile(openFileDialog.FileName);
            blank.RefreshAmount();
            blank.Show();
            saveToolStripMenuItem.Enabled = true;
        }

        private void SetOpenFileProperty()
        {
            openFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog.DefaultExt = ".rtf";
            openFileDialog.FileName = "Text file";
        }

        private void CreateNew()
        {
            Blank blank = new Blank();
            blank.DocName = "Untitled " + GetFreeUntitledNum();
            blank.Text = blank.DocName;
            blank.MdiParent = this;
            blank.WindowState = FormWindowState.Maximized;
            blank.RefreshAmount();
            blank.Show();
        }

        private int GetFreeUntitledNum()
        {
            int i;
            for (i = 1; i < UntitledNums.Count + 1; i++)
            {
                if (!UntitledNums.Contains(i)) break;
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

        private void ShowFontDialog()
        {
            Blank blank = (Blank)ActiveMdiChild;
            if (blank == null) return;
            fontDialog1.Font = blank.TextFont;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                blank.TextFont = fontDialog1.Font;
            }
        }

        private void ShowColorDialog()
        {
            Blank blank = (Blank)ActiveMdiChild;
            if (blank == null) return;
            colorDialog.Color = blank.TextColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                blank.TextColor = colorDialog.Color;
            }
        }

        public DialogResult ShowSaveDialog(string docName)
        {
            string title = Resources.GetString("mainform_save_title");
            string message = Resources.GetString("mainform_save_message") ?? "Do you want to save changes in {0}?";
            DialogResult dialogResult = MessageBox.Show(string.Format(message, docName),
                title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult;
        }

        private Bitmap GetImage()
        {
            SetOpenImageProperty();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return null;

            Bitmap bitmap = null;
            try
            {
                bitmap = new Bitmap(openFileDialog.FileName);
            }
            catch
            {
                string title = Resources.GetString("mainform_error_title");
                string message = Resources.GetString("mainform_wront_file_format");
                MessageBox.Show(message, title);
            }

            return bitmap;
        }

        private void SetOpenImageProperty()
        {
            openFileDialog.Filter = "All Files(*.*)|*.*";
            openFileDialog.DefaultExt = ".png";
            openFileDialog.FileName = "Image file";
        }


        public void SaveOrSaveAs(bool wasSaved)
        {
            if (wasSaved) Save();
            else SaveAs();
        }

        private void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            RefreshForm();
            CheckLanguageItem(lang);
        }

        private void RefreshForm()
        {
            RemoveUiControls();
            InitializeComponent();
            RefreshChildForms();
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }

        private void RemoveUiControls()
        {
            Controls.Remove(miniToolStrip);
            Controls.Remove(toolStripMain);
        }

        private void RefreshChildForms()
        {
            foreach (var mdiChild in MdiChildren)
            {
                Blank blank = (Blank)mdiChild;
                blank.RefreshAmount();
            }
        }

        private void CheckLanguageItem(string lang)
        {
            englishToolStripMenuItem.Checked = lang == "en";
            ukrainianToolStripMenuItem.Checked = lang == "uk";
        }
    }
}