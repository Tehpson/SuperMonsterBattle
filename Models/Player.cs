﻿using System.Collections.Generic;

namespace SuperMonsterBattle.Models
{
    internal class Player : Creature
    {
       
        public List<Item> Items { get; set; } = new List<Item>();
        public double Money { get; set; }

        public Player(string Name, int HP, uint Damage, double Money) : base(Name, HP, Damage) { this.Money = Money; }

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