using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class FindForm : Form
    {
        private FindNextSearch qry = new FindNextSearch();
        public RichTextBox Editor { get; internal set; }

        public FindForm()
        {
            InitializeComponent();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            btnFindNext.Enabled = txtFind.Text.Length > 0;
            UpdateSearchQuery();
        }

        private void UpdateSearchQuery()
        {
            qry.SearchString = txtFind.Text;
            qry.Direction = oUp.Checked ? "UP": "DOWN";
            qry.MatchCase = chkMatchCase.Checked;
            qry.Content = Editor.Text;
            qry.Position = Editor.SelectionStart;
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            UpdateSearchQuery();
            FindNextResult result = FindNext(qry);
            if (result.SearchStatus)
            {
                Editor.Select(result.SelectionStart, txtFind.Text.Length);
            }
        }

        private FindNextResult FindNext(FindNextSearch search)
        {
            FindNextResult result = new FindNextResult();
            int position;
            StringComparison s = search.MatchCase
                ? StringComparison.CurrentCulture
                : StringComparison.CurrentCultureIgnoreCase;

            if (search.Direction == "UP")
            {
                position = search.Content.Substring(0, search.Position)
                    .LastIndexOf(search.SearchString, s);
                search.Success = position >= 0;
            }
            else
            {
                int start = search.Position;
                if (search.Success)
                {
                    start += search.SearchString.Length;
                }
                position = start + search.Content
                    .Substring(start, search.Content.Length - start)
                    .IndexOf(search.SearchString, s);
                search.Success = position - start >= 0;
            }

            result.SearchStatus = search.Success;
            result.SelectionStart = position;

            return result;
        }
    }
}