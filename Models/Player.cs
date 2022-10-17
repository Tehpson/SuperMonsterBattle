using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Models
{
    class Player : ICreature
    {
        public string Name { get; set ; }
        public uint HP { get; set; }
        public uint Exp { get; set ; }

        public void GiveDamage()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
