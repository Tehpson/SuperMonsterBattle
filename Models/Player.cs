using System.Collections.Generic;

namespace AngeredSimulator.Models
{
    internal class Player : Creature
    {
       
        public List<StoreItem> Cloth { get; set; } = new List<StoreItem>();
        public List<DrugItem> Stash { get; set; } = new List<DrugItem>();
        public double Money { get; set; }
        public ushort Rep { get; set; }

        public Player(string Name, int HP, uint Damage, int Speed, ushort Rep, double Money) : base(Name, HP, Damage, Speed) { this.Money = Money; this.Rep = Rep; }

        public override uint TakeDamage(uint damage)
        {
            //TODO:Add item buff
            var damageTaken = damage;
            if (damage < 0)
            {
                return 0;
            }
            else
            {
                HP -= (int)damageTaken;
                return damageTaken;
            }
        }
    }
}