public class OutdoorGathering :Event{

    private string _weather;


    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address){
        _weather = weather;
    }

    public override string generateFullMessage(){
        return $"Title: {getTitle()}\nDescription: {getDescription()}\nType: Lecture\nDate: {getDate()}\nTime: {getTime()}\nWeather: {_weather}\n{getAddress()}";
    }

    
    public  string generateShortMessage(){
        return $"Type: Outdoor Gathering\nTitle: {getTitle()}\nDate: {getDate()}";
    }
}