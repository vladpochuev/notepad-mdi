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
        private HashSet<int> UntitledNums { get; set; }

        public MainForm()
        {
            InitializeComponent();
            UntitledNums = new HashSet<int>();
        }

        private void Save()
        {
            Blank blank = (Blank)ActiveMdiChild;
            blank.WriteFile(blank.DocName);
            blank.IsSaved = true;
        }

        private void Open()
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            Blank blank = new Blank();
            blank.MdiParent = this;
            blank.DocName = openFileDialog1.FileName;
            blank.Text = blank.DocName;
            blank.WasSaved = true;
            blank.ReadFile(openFileDialog1.FileName);
            blank.RefreshAmount();
            blank.Show();
            saveToolStripMenuItem.Enabled = true;
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

        private void SaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank blank = (Blank)ActiveMdiChild;
                blank.WriteFile(saveFileDialog1.FileName);
                if (!blank.WasSaved)
                {
                    SetFreeUntitledNum(blank.DocName);
                }

                blank.DocName = saveFileDialog1.FileName;
                blank.Text = saveFileDialog1.FileName;
                saveToolStripMenuItem.Enabled = true;
                blank.WasSaved = true;
                blank.IsSaved = true;
            }
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
            colorDialog1.Color = blank.TextColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                blank.TextColor = colorDialog1.Color;
            }
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