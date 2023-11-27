public class BreathingActivity: Activity
{

    public BreathingActivity() : base("Breathing"){}

    public void ExplainActivity(){
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
    }

    public void PlayActivity(){
        int timeActivity = GetTimeActivity();

        for(int i = 3; i > 0; i--){
            Console.Write("Now Breathe in..." + i);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }
        //with this line of code, the console will clear the line and then write the next line
        Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        // Console.WriteLine();
        Console.WriteLine("Breathe in...");

        for(int z = 4; z > 0; z--){
            Console.Write("Now Breathe out..." + z);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }
        Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        Console.WriteLine("Breathe out...");



        int times = (int)(timeActivity / 10);

        for(int x = 0; x < times; x++){
            Console.WriteLine();
            for(int u = 4; u > 0; u--){
            Console.Write("Now Breathe in..." + u);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            // Console.WriteLine();
            Console.WriteLine("Breathe in...");

            for(int f = 6; f > 0; f--){
                Console.Write("Now Breathe out..." + f);
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }

            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            Console.WriteLine("Breathe out...");           
        }
       
        
    }



    public void Run(){
        DisplayStartingMessage();
        ExplainActivity();
        SetTimeActivity();
        Console.Clear();
        ShowSpinner();
        PlayActivity();
        ShowCountDown();
    }
}