using System.Collections.Generic;

namespace SuperMonsterBattle.Models
{
    internal class Player : ICreature
    {
        public string Name { get; private set; }

        public uint HP
        {
            get
            {
                return HP;
            }
            set
            {
                if (value > HP)
                {
                    Dead = true;
                    HP = 0;
                }
            }
        }

        public uint Exp { get; private set; }
        public uint Damage { get; private set; }
        public bool Dead { get; private set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Player(string Name, uint HP, uint Damage)
        {
            this.Name = Name;
            this.HP = HP;
            this.Damage = Damage;
        }

        public uint GiveDamage()
        {
            //TODO: add Items to equation
            return Damage;
        }

        public uint TakeDamage(int damage)
        {
            //TODO: add Items to equation
            int damageTaken = damage;
            if (damage < 0)
            {
                return 0;
            }
            else
            {
                HP -= (uint)damageTaken;
                return (uint)damageTaken;
            }
        }
    }
}