using System.Collections.Generic;

namespace AngeredSimulator.Models
{
    public class StoreItem
    {
        public string Name { get; private set; }
        public uint Price { get; set; }
        public Dictionary<Stats, int> Effects { get; private set; } = new Dictionary<Stats, int>();

        public StoreItem(string Name, Dictionary<Stats, int> Effects)
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