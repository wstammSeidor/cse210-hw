using System.IO.Enumeration;

public class Promts{
    public string _promt = "";
    public List<string> _promts = new List<string>();

    public void LoadPromptsFromFile()
    {
        string filename = "prompts.txt"; 
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _promts.Add(line);
        }
    }

    public void ListPrompts()
    {
        _promts.Clear();
        LoadPromptsFromFile();
        Console.WriteLine("List of prompts:");
        foreach (string prompt in _promts)
        {
            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }

    public string GetOnePrompt()
    {
        LoadPromptsFromFile();
        Random rnd = new Random();
        int index = rnd.Next(_promts.Count);
        Console.WriteLine("Your prompt is: " + _promts[index]);
        return _promts[index];
    }

    public void AddPrompt(string newPrompt)
    {
        _promts.Add(newPrompt);
        string filename = "prompts.txt";
        File.AppendAllText(filename, "\n" +  newPrompt );
    }
}