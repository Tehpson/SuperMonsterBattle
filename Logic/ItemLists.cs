using SuperMonsterBattle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Logic
{
    class ItemLists
    {
        public static List<DrugItem> Drugs { get; private set; } = new List<DrugItem>();
        public static List<StoreItem> storeItems { get; private set; } = new List<StoreItem>();

        public static void Seed()
        {
            Drugs.Add(new DrugItem { Name = "Benzo", BuyPrice = 15, SellPrice = 17 });
            Drugs.Add(new DrugItem { Name = "Weed", BuyPrice = 140, SellPrice = 175 });
            Drugs.Add(new DrugItem { Name = "MDMA", BuyPrice = 600, SellPrice = 700 });
            Drugs.Add(new DrugItem { Name = "Heroin", BuyPrice = 2000, SellPrice = 2500 });
            Drugs.Add(new DrugItem { Name = "Cocaine", BuyPrice = 7000, SellPrice = 9000 });
            Drugs.Add(new DrugItem { Name = "Rhino ket", BuyPrice = 24000, SellPrice = 30000 });
            Drugs.Add(new DrugItem { Name = "2-DPMP", BuyPrice = 305000, SellPrice = 328000 });
            Drugs.Add(new DrugItem { Name = "Wonk", BuyPrice = 500000, SellPrice = 570000 });
            Drugs.Add(new DrugItem { Name = "Omega3", BuyPrice = 4000000, SellPrice = 5000000 });
            // 10% win game 90% die.
            Drugs.Add(new DrugItem { Name = "GON", BuyPrice = 1000000000, SellPrice = 0 });

        }
    }
}
