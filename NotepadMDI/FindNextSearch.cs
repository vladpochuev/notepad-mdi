using System;

namespace NotepadMDI
{
    public class FindNextSearch
    {
        public string SearchString { get; set; }
        public string Direction { get; set; }
        public bool MatchCase { get; set; }
        public string Content { get; set; }
        public int Position { get; set; }
        public bool Success { get; set; }

        public FindNextResult FindNext()
        {
            StringComparison comparison = MatchCase
                ? StringComparison.CurrentCulture
                : StringComparison.CurrentCultureIgnoreCase;
            int position = Direction == "UP" ? SearchUp(comparison) : SearchDown(comparison);
            FindNextResult result = new FindNextResult(position, Success);

            return result;
        }

        private int SearchUp(StringComparison comparison)
        {
            int position = Content.Substring(0, Position)
                .LastIndexOf(SearchString, comparison);
            Success = position >= 0;
            return position;
        }

        private int SearchDown(StringComparison comparison)
        {
            int start = Position;
            if (Success)
            {
                start += SearchString.Length;
            }

            int position = start + Content
                .Substring(start, Content.Length - start)
                .IndexOf(SearchString, comparison);
            Success = position - start >= 0;
            return position;
        }
    }
}