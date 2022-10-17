using System.Collections.Generic;

namespace SuperMonsterBattle.Models
{
    internal class Player : Creature
    {
       
        public List<Item> Items { get; set; } = new List<Item>();

        public Player(string Name, uint HP, uint Damage) : base(Name, HP, Damage) { }

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
                this.HP -= damageTaken;
                return damageTaken;
            }
        }
    }
}