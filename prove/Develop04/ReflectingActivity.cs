using System.Security.Cryptography;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>(){"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."} ;
    private List<string> _questions = new List<string>(){"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public ReflectingActivity() : base("Reflecting"){}


    public void ExplainActivity(){
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you to remember that you are capable of overcoming challenges.");
        Console.WriteLine();
    }

    public void PlayActivity(){
        int timeActivity = GetTimeActivity();
        int times = (int)(timeActivity / 10);
        Random rnd = new Random();
        int promptIndex = rnd.Next(0, _prompts.Count);
        int questionIndex = rnd.Next(0, _questions.Count);

       
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine("\t"+ "---" + _prompts[promptIndex] + "---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press any key to continue.");
        Console.ReadKey();
        Console.WriteLine("Now ponder on each of the following questions as they realated on this experience.");
        for(int x = 5; x > 0; x--){
            Console.Write("You may begin in..." + x);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }
        Console.Clear();

        for(int i = 0; i < times; i++){
            Console.WriteLine();
            Console.WriteLine("\t" + "---" + _questions[questionIndex] + "---");
            Console.WriteLine();
            questionIndex = rnd.Next(0, _questions.Count);
            DateTime endTime = DateTime.Now.AddSeconds(10);
            while(DateTime.Now < endTime){
                Thread.Sleep(1000);
                Console.Write("\t.");
            }
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