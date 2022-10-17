using SuperMonsterBattle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Logic
{
    internal class ItemController
    {
        public Dictionary<IItem,int> Inventory { get; set; }
    }
}
