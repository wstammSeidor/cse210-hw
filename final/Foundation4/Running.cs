public class Running : Activity
{
    private int _distance; //in kilometers


    public Running(string date, int length,string type , int distance) : base(date, length,"Running")
    {
        _distance = distance;
    }

    public override float getDistance()
    {
        return _distance;
    }

    public override float getSpeed()
    {

        float speed = (60 * _distance) / getLength();
        return speed;
    }

    public override float getPace()
    {
        float pace = getLength() / _distance;
        return pace;
    }



}