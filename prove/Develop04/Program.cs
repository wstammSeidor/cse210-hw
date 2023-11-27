using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while(option != "4"){
        Console.Clear();
        Console.WriteLine("Menu options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");
        option = Console.ReadLine();
        Console.WriteLine(option);
        Console.Clear();

        
       switch (option)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

}