namespace NotepadMDI
{
    public class FindNextResult
    {
        public bool SearchStatus { get; set; }
        public int SelectionStart { get; set; }

        public FindNextResult()
        {
        }

        public FindNextResult(int selectionStart, bool searchStatus)
        {
            SelectionStart = selectionStart;
            SearchStatus = searchStatus;
        }
    }
}