namespace W1_assignment_template
{
    public interface IFileHandler
    {
        void ReadToList(List<Character> characters);
        void PrintList(List<Character> characters);
        void FindCharacter(List<Character> characters);
        void NewCharacter(List<Character> characters);
        void UpdateCharacter(List<Character> characters);
        void SaveToFile(List<Character> characters);
    }
}
