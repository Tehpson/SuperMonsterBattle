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
            Drugs.Add(new DrugItem { Name = "Benzo", BuyPrice = 15, SellPrice = 17 ,  Wanted = 40});
            Drugs.Add(new DrugItem { Name = "Weed", BuyPrice = 140, SellPrice = 175,Wanted = 80 });
            Drugs.Add(new DrugItem { Name = "MDMA", BuyPrice = 600, SellPrice = 700 , Wanted = 40});
            Drugs.Add(new DrugItem { Name = "Heroin", BuyPrice = 2000, SellPrice = 2500, Wanted = 30 });
            Drugs.Add(new DrugItem { Name = "Cocaine", BuyPrice = 7000, SellPrice = 9000, Wanted = 20 });
            Drugs.Add(new DrugItem { Name = "Rhino ket", BuyPrice = 24000, SellPrice = 30000, Wanted = 10 });
            Drugs.Add(new DrugItem { Name = "2-DPMP", BuyPrice = 305000, SellPrice = 328000, Wanted = 25 });
            Drugs.Add(new DrugItem { Name = "Wonk", BuyPrice = 500000, SellPrice = 57000, Wanted = 35 });
            Drugs.Add(new DrugItem { Name = "Omega3", BuyPrice = 4000000, SellPrice = 5000000, Wanted = 25 });
            // 10% win game 90% die.
            Drugs.Add(new DrugItem { Name = "GON", BuyPrice = 1000000000, SellPrice = 0, Wanted = 100 });

        }
    }
}
