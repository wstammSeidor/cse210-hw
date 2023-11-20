public class Word{
    private string _text ;
    private bool _isHidden = false;



    public Word(string text){
        _text = text;
    }
    public void Hide(){
        _isHidden = true;
    }

    public void Show(){
        _isHidden = false;
    }

    public bool isHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        if(_isHidden){
            return "______";
        }else{
            return _text;
        }
    }

}