namespace W1_assignment_template
{
    public class DataManager
    {
        public string FileName { get; set; }
        public List<Character> Characters { get; set; }
        public DataManager(string fileName = "Files/input.csv")
        {
            Characters = new List<Character>();
            FileName = fileName;
        }
    }
}
