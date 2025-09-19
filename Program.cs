using System.Reflection.Emit;
using W1_assignment_template;

partial class Program
{
    static void Main()
    {
        CharacterHandler handler = new CharacterHandler(new JsonFileHandler());

        bool isTrue = true;
        while (isTrue)
        {
            // Display the menu and prompt the user to enter an option
            DisplayMenu();
            Console.Write("\nChoose an option> ");
            var userInput = Console.ReadLine();

            if (userInput == "1") // list the pre-existing characters
            {
                handler.ReadAllCharacters();
            }
            else if (userInput == "2") // Add a character to the list
            {
                handler.AddCharacter();
            }
            else if (userInput == "3") // Update an existing character
            {
                handler.LvlUpCharacter();
            }
            else if (userInput == "4") // Find a specific character
            {
                handler.FindCharacter();
            }
            else if (userInput == "5")
            {
                handler.SaveCharacters(handler.Characters);
                isTrue = false;
            }
            else // if the user enters something other than 1, 2, or 3, then the program quits
            {
                Console.WriteLine("Invalid option selected");
            }
        }
    }
    static void DisplayMenu() // Displays the menu
    {
        Console.WriteLine("\n\n1. Display Characters");
        Console.WriteLine("2. Add Character");
        Console.WriteLine("3. Update Character");
        Console.WriteLine("4. Find Character");
        Console.WriteLine("5. Save and Exit Application");
    }
}