using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NotepadMDI
{
    public class SyntaxHighlighter
    {
        private RichTextBox RichTextBox { get; set; }

        public SyntaxHighlighter(RichTextBox richTextBox)
        {
            RichTextBox = richTextBox;
        }

        public void Highlight()
        {
            int selectionStart = RichTextBox.SelectionStart;
            int selectionLength = RichTextBox.SelectionLength;

            CodeBlockFinder blockFinder = new CodeBlockFinder(RichTextBox.Text);

            while (blockFinder.HasNext())
            {
                blockFinder.Next();
                int blockStart = blockFinder.CodeBlockStart;
                int blockLength = blockFinder.CodeBlockLength;
                string codeBlockText = RichTextBox.Text.Substring(blockStart, blockLength);

                SetDefaultStyle(blockStart, blockLength);
                HighlightKeywords(codeBlockText, blockStart);
            }

            RichTextBox.SelectionStart = selectionStart;
            RichTextBox.SelectionLength = selectionLength;
        }

        private void SetDefaultStyle(int blockStart, int blockLength)
        {
            RichTextBox.SelectionStart = blockStart;
            RichTextBox.SelectionLength = blockLength;

            RichTextBox.SelectionFont = new Font("Courier New", 12);
            RichTextBox.SelectionColor = Color.Black;
            RichTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void HighlightKeywords(string text, int globalBlockStart)
        {
            foreach (CSharpKeyword cSharpKeyword in Enum.GetValues(typeof(CSharpKeyword)))
            {
                string keyword = cSharpKeyword.ToString();
                string pattern = "(?<=(^|\\W|\\s))" + keyword + "(?=\\W|\\s)";

                MatchCollection matches = Regex.Matches(text, pattern);

                foreach (Match match in matches)
                {
                    RichTextBox.SelectionStart = match.Index + globalBlockStart;
                    RichTextBox.SelectionLength = match.Length + globalBlockStart;
                    RichTextBox.SelectionColor = Color.Chocolate;
                }
            }
        }
    }
}