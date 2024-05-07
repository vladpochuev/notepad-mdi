using System;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class FindForm : Form
    {
        private FindNextSearch Search { get; set; }
        public RichTextBox Editor { get; internal set; }

        public FindForm()
        {
            InitializeComponent();
            Search = new FindNextSearch();
        }

        private void UpdateSearchQuery()
        {
            Search.SearchString = txtFind.Text;
            Search.Direction = oUp.Checked ? "UP" : "DOWN";
            Search.MatchCase = chkMatchCase.Checked;
            Search.Content = Editor.Text;
            Search.Position = Editor.SelectionStart;
        }

        private void FindNext()
        {
            UpdateSearchQuery();
            FindNextResult result = Search.FindNext();
            if (result.SearchStatus)
            {
                Editor.Select(result.SelectionStart, txtFind.Text.Length);
            }
        }
    }
}