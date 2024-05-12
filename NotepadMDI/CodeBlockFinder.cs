using System.Text.RegularExpressions;

namespace NotepadMDI
{
    public class CodeBlockFinder
    {
        public int CodeBlockStart { get; set; }
        public int CodeBlockLength { get; set; }
        private MatchCollection Matches { get; set; }
        private int MatchesIndex;
        private string CODE_BLOCK_PATTERN = "\\/\\/\\/[\\s\\S]+?\\/\\/\\/";

        public CodeBlockFinder(string text)
        {
            Matches = Regex.Matches(text, CODE_BLOCK_PATTERN);
        }

        public bool HasNext()
        {
            return MatchesIndex < Matches.Count;
        }

        public void Next()
        {
            CodeBlockStart = Matches[MatchesIndex].Index;
            CodeBlockLength = Matches[MatchesIndex].Length;
            MatchesIndex++;
        }
    }
}