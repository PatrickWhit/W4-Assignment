using Newtonsoft.Json;

namespace W1_assignment_template
{
    public class JsonFileHandler : DataManager, IFileHandler
    {
        public JsonFileHandler()
        {
            FileName = "Files/input.json";
        }
        public void ReadToList() // reads from input.json
        {
            var json = File.ReadAllText(FileName);
            var character = JsonConvert.DeserializeObject<List<Character>>(json);

            Characters.AddRange(character);
        }
        public void SaveToFile() // Saves all the charcaters in the list to input.csv
        {
            // Not sure if this writes to the Json file, or Just takes the characters and puts them into a string
            string json = JsonConvert.SerializeObject(Characters);
            //File.AppendText(FileName, json);
        }
    }
}
