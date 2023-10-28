class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden
    {
        get { return _hidden; }
    }
}