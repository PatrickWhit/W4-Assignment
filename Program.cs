using System.Reflection.Emit;
using W1_assignment_template;

class Program
{
    static void DisplayMenu() // Displays the menu
    {
        Console.WriteLine("1. Display Characters");
        Console.WriteLine("2. Add Character");
        Console.WriteLine("3. Update Character");
        Console.WriteLine("4. Find Character");
    }

    static void Main()
    {
        // Get the list of characters FileManager.cs
        //var characters = new Character();
        //characters.ReadCharactersToList();
        IFileHandler characters = new JsonFileHandler;
        CharacterReader.ReadToList(characters);

        // Display the menu and prompt the user to enter an option
        DisplayMenu();
        Console.Write("\nChoose an option> ");
        var userInput = Console.ReadLine();

        if (userInput == "1") // list the pre-existing characters
        {
            CharacterReader.PrintList(characters);
        }
        else if (userInput == "2") // Add a character to the list
        {
            CharacterWriter.NewCharacter(characters); // call a class that adds a new character to the list
        }
        else if (userInput == "3") // Update an existing character
        {
            CharacterWriter.UpdateCharacter(characters);
        }
        else if (userInput == "4") // Find a specific character
        {
            CharacterReader.FindCharacter(characters);
        }
        else // if the user enters something other than 1, 2, or 3, then the program quits
        {
            Console.WriteLine("Invalid option selected");
        }
    }
}