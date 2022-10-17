using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Models
{
    class Monster : Creature
    {
        public Monster(string Name, uint HP, uint Damage) : base(Name, HP, Damage) { }
    }
}
