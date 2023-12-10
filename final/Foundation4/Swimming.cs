public class Swimming : Activity{
    private int _laps;


    public Swimming(string date, int length,string type , int laps) : base(date, length,"Swimming")
    {
        _laps = laps;
    }

    public override float getDistance()
    {
        float distance = (_laps * 50 ) / 1000; 
        return distance;
    }

    public override float getSpeed()
    {
        float speed = (60 * getDistance()) / getLength();
        return speed;
    }

    public override float getPace()
    {
        float pace = getLength() / getDistance();
        return pace;
    }
}