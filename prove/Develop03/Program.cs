using System;


public class PRogram
{
    static void Main(string[] args)
    {
        //Shows scripture and user interaction here
        string reference = "Proverbs 3:5-6";
        string scriptureText = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine($"{reference}: \"{scriptureText}\"");
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:")

        while (true) //begin a infitie loop
        {
            
            string input = console.Readline();

            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            scripture.HideRandomWords(1);
            Console.Clear();
            Console.WriteLine(scripture.GetScriptureWithHiddenWords());
    
        }
        

    }
}