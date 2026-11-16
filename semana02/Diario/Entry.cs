
class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Data: {_date}");
        Console.WriteLine($"Pergunta: {_promptText}");
        Console.WriteLine($"Resposta: {_entryText}");
        Console.WriteLine();
    }

    public string GetFileFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
