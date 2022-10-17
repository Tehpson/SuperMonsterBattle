using System.Collections.Generic;

namespace SuperMonsterBattle.Models
{
    public class Item
    {
        public string Name { get; private set; }
        public Dictionary<Stats, int> Effects { get; private set; } = new Dictionary<Stats, int>();

        public Item(string Name, Dictionary<Stats, int> Effects)
        {
            this.Name = Name;
            this.Effects = Effects;
        }
    }
    public enum Stats
    {
        HP,
        Damage,
        Speed,
    }
}