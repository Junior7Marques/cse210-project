class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertTextToWords(text);
    }

    static public List<Word> ConvertTextToWords(string text)
    {
        string[] wordsArray = text.Split(' ');

        List<Word> words = new List<Word>(wordsArray.Select(word => new Word(word)));
        return words;
    }

    public string GetText()
    {
        string text = "";
        _words.ForEach(word => text += word.GetWord() + " ");
        return text;
    }

    public void HideWord()
    {
        Random random = new Random();
        int index = random.Next(0, _words.Count);
        _words[index].Hide();
        // _words.Find(w => w.GetWord() == word).Hide();
    }
}