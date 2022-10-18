using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Models
{
    internal class DrugItem
    {
        public string Name { get; set; }
        public uint SellPrice { get; set; }
        public uint BuyPrice { get; set; }
        public uint Amount { get; set; }
        public ushort Wanted { get; set; }
        public int Rarity { get; set; }
    }
}
