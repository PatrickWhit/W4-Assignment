namespace W1_assignment_template
{
    public interface IFileHandler
    {
        List<Character> ReadToList();
        void SaveToFile(List<Character> characters);
    }
}
