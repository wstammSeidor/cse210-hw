public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

    private int _count = 0;


    public ListingActivity() : base("Listing"){}


    public void ExplainActivity(){
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
    }


    public void PlayActivity(){
        int timeActivity = GetTimeActivity();
        Random rnd = new Random();
        int promptIndex = rnd.Next(0, _prompts.Count);
        Console.WriteLine("List as many responses you can to following prompt:");
        Console.WriteLine();
        Console.WriteLine("\t" + "---" + _prompts[promptIndex] + "---");
        Console.WriteLine("You may begin in:");

        DateTime endTime = DateTime.Now.AddSeconds(timeActivity);

        while(DateTime.Now < endTime){
            
            Console.Write("\t>");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine();
        Console.WriteLine("You listed " + _count + " items!");


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