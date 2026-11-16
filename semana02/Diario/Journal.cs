
class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Seu diário está vazio.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetFileFormat());
            }
        }

        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Diário carregado com sucesso!");
    }
}
