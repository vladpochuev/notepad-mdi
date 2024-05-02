using System;
using System.Windows.Forms;

namespace NotepadMDI
{
    public partial class FindForm : Form
    {
        public string FindText
        {
            get => textBoxFind.Text;
            set => textBoxFind.Text = value;
        }

        public RichTextBoxFinds FindCondition
        {
            get
            {
                RichTextBoxFinds finds = RichTextBoxFinds.None;
                if (checkBoxMatchCase.Checked) finds |= RichTextBoxFinds.MatchCase;
                if (checkBoxMatchWholeWord.Checked) finds |= RichTextBoxFinds.WholeWord;
                return finds;
            }
        }
        public FindForm()
        {
            InitializeComponent();
        }
    }
}