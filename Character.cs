namespace W1_assignment_template
{
    public class Character
    {
        public string name { get; set; }
        public string charClass { get; set; }
        public string lvl { get; set; }
        public string hp { get; set; }
        public string equipment { get; set; }
        public List<Character> Characters { get; set; }


        public Character()
        {
            Characters = new List<Character>();
        }

        public Character(string Name, string CharClass, string Lvl, string Hp, string Equipment)
        {
            name = Name;
            charClass = CharClass;
            lvl = Lvl;
            hp = Hp;
            equipment = Equipment;
        }
    }
}
