namespace NotepadMDI
{
    public class FindNextSearch
    {
        public string SearchString { get; set; }
        public string Direction { get; set; }
        public bool MatchCase { get; set; }
        public bool WholeWord { get; set; }
        public string Content { get; set; }
        public int Position { get; set; }
        public bool Success { get; set; }
    }
}