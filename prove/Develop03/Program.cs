using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        Referece referecia = new Referece("John", 3, 3, 5);
        List<string> script = new List<string> {
        "Jesus", "answered", "and", "said", "unto", "him,", "Verily,", "verily,", "I", "say", "unto", "thee,", "Except", "a", "man", "be", "aborn", "bagain,", "he", "cannot", "csee", "the", "kingdom", "of", "God.",
        "Nicodemus", "saith", "unto", "him,", "How", "can", "a", "man", "be", "born", "when", "he", "is", "old?", "can", "he", "enter", "the", "second", "time", "into", "his", "mother’s", "womb,", "and", "be", "born?",
        "Jesus", "answered,", "Verily,", "verily,", "I", "say", "unto", "thee,", "Except", "a", "man", "be", "aborn", "of", "bwater", "and", "of", "the", "cSpirit,", "he", "cannot", "denter", "into", "the", "kingdom", "of", "God."
        };

        
        List<Word> words = new List<Word>();

        for (int i = 0; i < script.Count; i++)
        {
            Word word = new Word(script[i]);
            words.Add(word);
        
        }

        Scripture scripture = new Scripture(referecia, words);

        
         while (option != "quit" )
        {
            // Console.Clear();
            Console.WriteLine("Please, enter to continue or type 'quit' to exit"); 
            // I have add this option, if the any user type quit in capital letters, the program will not exit
            option = Console.ReadLine().ToLower();;

            if (option == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                // Console.Clear();
                scripture.HideRandomWords(5);
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press enter to continue");
            }
        }   
    }
}