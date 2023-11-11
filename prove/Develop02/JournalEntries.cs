public class JournalEntries{
    public DateTime _date = DateTime.Now;
    public string _entry = "";

    public Promts _prompt = new Promts();


    public void JournalEntrie(string entry,string prompt){
        _date = DateTime.Now;
        _entry = entry;
        _prompt._promt = prompt;
    }


    public void SaveJournalEntry(){
        string filename = "journal.txt";
        File.AppendAllText(filename, "\n" + _date + "\n" + _prompt._promt + "\n" + _entry + "\n");
    }
}