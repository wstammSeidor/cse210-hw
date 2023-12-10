using System.Runtime.CompilerServices;

public abstract class Activity
{
   private string _date;
   private int _length; //in minutes
   private string _type;

    public Activity(string date, int length , string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }

    public abstract float getDistance();
    public abstract float getSpeed();
    public abstract float getPace();

    public string getDate()
    {
        return _date;
    }
    public int getLength()
    {
        return _length;
    }


    public string GetSummary()
    {

        string summary = _date + " " + _type + " (" + _length + " min): Distance " + getDistance() + " km, Speed: " + getSpeed() + " kph, Pace: " + getPace() + " min per km";

        return summary;
    }




}