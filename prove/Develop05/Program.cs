using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have 0 points.");
        Console.WriteLine();


        int choice = 0;

        while(choice != 6){

        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create a New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record an Event");
        Console.WriteLine("\t6. Quit");

        Console.Write("Enter your choice: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Option1();
                break;

            case 2:
                Console.WriteLine("List Goals");
                break;

            case 3:
                Console.WriteLine("Save Goals");
                break;

            case 4:
                Console.WriteLine("Load Goals");
                break;

            case 5:
                Console.WriteLine("Record an Event");
                break;

            case 6:
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }

        }
    }



    static void Option1(){

        Console.WriteLine("Create a New Goal");
        Console.WriteLine();

        Console.WriteLine("Goal Types:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                
                break;

            case 2:
                Console.WriteLine("Eternal Goal");
                break;

            case 3:
                Console.WriteLine("Checklist Goal");
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }

    }
}