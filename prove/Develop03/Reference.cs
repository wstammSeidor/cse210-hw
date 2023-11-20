using System.Threading.Tasks.Dataflow;

public class Referece{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;

    private int _endVerse = 0;

    public Referece(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Referece(string book, int chapter, int verse){
        _book = "";
        _chapter = 0;
        _verse = 0;
    }


    public string GetDisplayText(){
        return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }

}