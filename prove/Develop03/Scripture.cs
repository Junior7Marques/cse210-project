class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _hiddenWordCount;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertTextToWords(text);
        _hiddenWordCount = 0;
    }

    public string GetText()
    {
        string text = "";
        foreach (var word in _words)
        {
            text += word.GetWord() + " ";
        }
        return text;
    }

    public void HideWord()
    {
        if (_hiddenWordCount < _words.Count)
        {
            Random random = new Random();
            int index;
            do
            {
                index = random.Next(0, _words.Count);
            } while (_words[index].IsHidden);
            _words[index].Hide();
            _hiddenWordCount++;
        }
    }

    public bool AllWordsHidden()
    {
        return _hiddenWordCount == _words.Count;
    }

    private List<Word> ConvertTextToWords(string text)
    {
        string[] wordsArray = text.Split(' ');

        List<Word> words = new List<Word>(wordsArray.Select(word => new Word(word)));
        return words;
    }
}