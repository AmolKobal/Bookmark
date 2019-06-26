namespace WinFormBookmark
{
    internal class Bookmark
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int Minimum;
        public int Maximum;
        public string Current;
        public string Info { get; set; }

        public string Status { get; set; }

    }
}