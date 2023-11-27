public class Activity {
    
    private string _name;
    private int _timeActivity;


    public Activity(string name){
        _name = name;
    }

    public int GetTimeActivity(){
        return _timeActivity;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine("Welcome to the " + _name + " Activity!");
        Console.WriteLine();
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("You have completed another " + _timeActivity + " seconds of " + _name + " activity!");
    }

    public void SetTimeActivity(){
        Console.Write("How long, in seconds, would you like for your session? ");
        _timeActivity = Convert.ToInt32(Console.ReadLine());
    }

    public void ShowSpinner(){
        Console.WriteLine("Get ready...");
        List<string> spinner = new List<string>(){"|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-", "\\"};
        for(int i = 0; i < 8; i++){
            Console.Write(spinner[i]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        Console.WriteLine("");
        Console.WriteLine();
    }

    public void ShowCountDown(){

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine("You have completed another " + _timeActivity + " seconds of " + _name + " activity!");
         List<string> spinner = new List<string>(){"|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-", "\\"};
        for(int i = 0; i < 8; i++){
            Console.Write(spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

    }


}