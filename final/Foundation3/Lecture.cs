public class Lecture : Event{
    private string _speakerName;

    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address) {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string generateFullMessage(){
        return $"Title: {getTitle()}\nDescription: {getDescription()}\nType: Lecture\nDate: {getDate()}\nTime: {getTime()}\nSpeaker Name: {_speakerName}\nCapacity: {_capacity}\n{getAddress()}";
    }

    public  string generateShortMessage(){
        return $"Type: Lecture\nTitle: {getTitle()}\nDate: {getDate()}";
    }
}