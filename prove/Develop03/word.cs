public class Word
{
    public string Value { get; private set; }

    public Word(string value)
    {
        Value = value;
    }

    public void Hide()
    {
        Value = "_____";
    }
}
