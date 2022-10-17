using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Models
{
    internal class DrugItem : IItem
    {
        public string Name { get; set; }
        public uint SellPrice { get; set; }
        public uint BuyPrice { get; set; }
    }
}
