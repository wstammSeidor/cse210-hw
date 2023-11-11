using System;

public class Journal{
    public List <JournalEntries> _entries = new List<JournalEntries>(); 



    public void ListJournalEntries(){
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}