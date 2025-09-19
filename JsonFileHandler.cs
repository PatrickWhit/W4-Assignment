using Newtonsoft.Json;

namespace W1_assignment_template
{
    public class JsonFileHandler : IFileHandler
    {
        private string _fileName = "Files/input.json";

        public List<Character> ReadToList() // reads from input.json
        {
            var json = File.ReadAllText(_fileName);
            var character = JsonConvert.DeserializeObject<List<Character>>(json);

            List<Character> characters = new List<Character>();
            characters.AddRange(character);

            return characters;
        }
        public void SaveToFile(List<Character> characters) // Saves all the charcaters in the list to input.csv
        {
            string json = JsonConvert.SerializeObject(characters);

            File.WriteAllText(_fileName, json); // delete all data in the file so it can be rewriten

            //using (StreamWriter writer = new StreamWriter(_fileName, true)) // writes the header to input.csv
            //{
            //    writer.WriteLine("Name,Class,Level,HP,Equipment"); // write the header in first

            //    foreach (var c in characters)
            //    {
            //        writer.WriteLine($"{c.name},{c.charClass},{c.lvl},{c.hp},{c.equipment}"); // then write in all characters
            //    }
            //}
        }
    }
}
