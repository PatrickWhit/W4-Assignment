namespace W1_assignment_template
{
    public class CharacterHandler : DataManager
    {
        static public void ReadAllCharacters() // read all character from the list
        {
            foreach (var c in Characters)
            {
                Console.WriteLine($"\nCharacter Name: {c.name}");
                Console.WriteLine($"Character Class: {c.charClass}");
                Console.WriteLine($"Character Level: {c.lvl}");
                Console.WriteLine($"Character Health: {c.hp}");
                Console.WriteLine("Equipment:");

                foreach (var e in c.equipment.Split('|'))
                {
                    Console.WriteLine($"\t{e}");
                }

                Console.WriteLine("--------------------\n");
            }
        }

        static public void AddCharacter() // add a character to the character list
        {
            var newChar = new Character(); // initilization of new character

            Console.Write("\nEnter your character's name: "); // give character a name
            newChar.name = Console.ReadLine();

            Console.Write("Enter your character's class: "); // give character a class
            newChar.charClass = Console.ReadLine();

            Console.Write("Enter your character's level: "); // give character a level
            newChar.lvl = Console.ReadLine();

            Console.Write("Enter your character's health points: "); // give character health amount
            newChar.hp = Console.ReadLine();

            Console.Write("Enter your character's equipment (separate items with a '|'): "); // give character a equipment
            newChar.equipment = Console.ReadLine();

            Characters.Add(newChar); // add the new character to the character list
        }

        static public void FindCharacter() // finds a specific character based on the name entered
        {
            string userInput = null;

            Console.Write("\nType in the name of the character you wish to see> ");
            userInput = Console.ReadLine();

            var selectedChar = Characters.FirstOrDefault(c => c.name == userInput);

            if (selectedChar != null)
            {
                Console.WriteLine($"Name: {selectedChar.name}");
                Console.WriteLine($"Class: {selectedChar.charClass}");
                Console.WriteLine($"Level: {selectedChar.lvl}");
                Console.WriteLine($"Health: {selectedChar.hp}");
                Console.WriteLine("Equipment:");

                foreach (var e in selectedChar.equipment.Split('|'))
                {
                    Console.WriteLine($"\t{e}");
                }
            }
            else
            {
                Console.WriteLine("No character Found");
            }
        }

        static public void LvlUpCharacter() // add a level and health to a character
        {
            string userInput = null;

            Console.WriteLine("\nList of Characters: ");

            foreach (var c in Characters) // foreach loop lists the names of all the characters
            {
                Console.WriteLine($"\t{c.name}");
            }

            Console.Write("\nType in the name of the character you want to update> "); // user selects which character they want to update
            userInput = Console.ReadLine();

            var selectedChar = Characters.FirstOrDefault(c => c.name == userInput);

            int updatedLvl = int.Parse(selectedChar.lvl) + 1; // store updated numbers in new variables
            int updatedHp = int.Parse(selectedChar.hp) + 6;

            selectedChar.lvl = updatedLvl.ToString(); // take variables and convert them to strings to place in character
            selectedChar.hp = updatedHp.ToString();
        }
    }
}
