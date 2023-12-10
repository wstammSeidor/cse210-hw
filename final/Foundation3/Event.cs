using System.Net.Sockets;

public class Event{
    private string _title;

    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    /*Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

They would like the ability to generate three different messages:

Standard details - Lists the title, description, date, time, and address.
Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
Short description - Lists the type of event, title, and the date.*/
    public string generateStandardMessage(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{getAddress()}";
        
       
    }

    public virtual string generateFullMessage(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}";

    }

    

    public string getTitle(){
        return _title;
    }

    public string getDescription(){
        return _description;
    }

    public string getDate(){
        return _date;
    }
    public string getTime(){
        return _time;
    }
    public string  getAddress(){
        return "Address: " + _address.getStreet() + " " + _address.getCity() + " " + _address.getState() + " "  + _address.getCountry() + " ";
    }




}