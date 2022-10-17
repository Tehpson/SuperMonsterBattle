using System.Collections.Generic;

namespace SuperMonsterBattle.Models
{
    public class Item
    {
        public string Name { get; private set; }
        public Dictionary<Stat, int> Effects { get; private set; } = new Dictionary<Stat, int>();

        public Item(string Name, Dictionary<Stat, int> Effects)
        {
            this.Name = Name;
            this.Effects = Effects;
        }
    }
    public enum Stat
    {
        HP,
        Damage,
        Speed,
    }
}