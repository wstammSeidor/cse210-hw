
using System.Xml.XPath;

public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }


    public int getTop(){
        return _top;
    }

    public int getBottom(){
        return _bottom;
    }

    public void setTop(int top){
        _top = top;
    }

    public void setBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        string result = $"{_top}/{_bottom}";
        return result;
    }

    public double GetDecimalValue(){
        double result = (double)_top / (double)_bottom;
        return result;
    }



}