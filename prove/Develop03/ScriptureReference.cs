    public class ScriptureReference
    {
        public string Book { get; }
        public int Chapter { get; }
        public int Verse { get; }

        public ScriptureReference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }
