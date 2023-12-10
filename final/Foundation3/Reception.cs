public class Reception : Event{

    private string _rsvpEmail;


    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail): base(title, description, date, time, address){
        _rsvpEmail = rsvpEmail;
    }

    public override string generateFullMessage(){
        return $"Title: {getTitle()}\nDescription: {getDescription()}\nType: Lecture\nDate: {getDate()}\nTime: {getTime()}\nRSVP Email: {_rsvpEmail}\n{getAddress()}";
    }

    public  string generateShortMessage(){
        return $"Type: Reception\nTitle: {getTitle()}\nDate: {getDate()}";
    }

    
}