public class StationaryBicycle : Activity
{
    private float _speed;

    public StationaryBicycle(string date, int length,string type ,float speed) : base(date, length,"StationaryBicycle")
    {
        _speed = speed;
    }


    public override float getDistance()
    {
        float distance = (_speed * getLength()) / 60;
        return distance;
    }

    public override float getSpeed()
    {
        return _speed;
    }

    public override float getPace()
    {
        float pace = 60 / _speed;
        return pace;
    }



}