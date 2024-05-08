    public class Scripture
    {
        public ScriptureReference Reference { get; }
        private List<Word> _words;

        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideWords(int numWordsToHide)
        {
            Random random = new Random();
            for (int i = 0; i < numWordsToHide; i++)
            {
                int index = random.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return _words.All(word => word.Value.Equals("_____"));
        }

        public void Display()
        {
            Console.WriteLine($"Referencia: {Reference}");
            Console.WriteLine("Texto:");
            foreach (var word in _words)
            {
                Console.Write($"{word.Value} ");
            }
            Console.WriteLine();
        }
    }
