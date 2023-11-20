using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Promts prompt = new Promts();

            if (option == 1)
            {   
                JournalEntries journalEntry = new JournalEntries();
                Console.WriteLine();
                string text = prompt.GetOnePrompt();
                Console.WriteLine("Please enter your journal entry:");
                string entry = Console.ReadLine();
                journalEntry.JournalEntrie(entry, text);

                Console.WriteLine("Would you like to save your entry? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    journalEntry.SaveJournalEntry();
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Okay, no entry saved.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
            else if (option == 2)
            {
                Journal journal = new Journal();
                journal.ListJournalEntries();

                
            }
            else if (option == 3)
            {
                prompt.ListPrompts();

                Console.WriteLine("Would you like to add a new prompt? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Please enter your new prompt:");
                    string newPrompt = Console.ReadLine();
                    prompt.AddPrompt(newPrompt);
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Okay, no new prompt added.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
            else if (option == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            
        }
    }
}