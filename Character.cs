using Newtonsoft.Json;

namespace W1_assignment_template
{
    public class Character
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("class")]
        public string charClass { get; set; }
        [JsonProperty("level")]
        public string lvl { get; set; }
        [JsonProperty("hp")]
        public string hp { get; set; }
        [JsonProperty("equipment")]
        public string equipment { get; set; }


        public Character() { }

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
