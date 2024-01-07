using System.Collections.Generic;

namespace AngeredSimulator.Models
{
    public class StoreItem(string Name, Dictionary<Stats, int> Effects)
    {
        public string Name { get; private set; } = Name;
        public uint Price { get; set; }
        public Dictionary<Stats, int> Effects { get; private set; } = Effects;
    }
    public enum Stats
    {
        HP,
        Damage,
        Speed,
    }
}