using SuperMonsterBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperMonsterBattle.Logic
{
    internal class SilkRoad
    {
        public List<DrugItem> InStorage { get; set; } = new List<DrugItem>();
        private int SelectedItem = 0;

        public SilkRoad()
        {
            UpdateSilkRoad();
        }

        public void UpdateSilkRoad()
        {
            var rnad = new Random();
            InStorage.Clear();
            foreach (var item in ItemLists.Drugs)
            {
                var r = rnad.Next(98, 105);
                decimal flux = r / 100m;
                item.BuyPrice = (uint)(item.BuyPrice * flux);
                item.Amount = 10;
                InStorage.Add(item);
            }
        }

        public void VisitSilkRoad(Player player, ref State state)
        {
            Visuals.Visual.DrawSilkRoad(InStorage, SelectedItem);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (SelectedItem != 0)
                        SelectedItem--;
                    break;

                case ConsoleKey.DownArrow:
                    if (SelectedItem != 10)
                        SelectedItem++;
                    break;

                case ConsoleKey.Enter:
                    Buy(player, SelectedItem);
                    break;

                case ConsoleKey.Escape:
                    state = State.Menu;
                    break;
            }
        }

        private void Buy(Player player, int SelectedItem)
        {
            var item = InStorage[SelectedItem];
            if (item.BuyPrice < player.Money && InStorage[SelectedItem].Amount > 0)
            {
                player.Money -= item.BuyPrice;
                item.Amount--;
                var drugItem = player.Stash.FirstOrDefault(x => x.Name == item.Name);
                if(drugItem != null)
                {
                    drugItem.Amount++;
                }
                else
                {
                    var standard = ItemLists.Drugs.Find(x => x.Name == item.Name);
                    var newitem = new DrugItem { Name = standard.Name , Amount = 1, BuyPrice = standard.BuyPrice, SellPrice = standard.SellPrice};
                    player.Stash.Add(newitem);
                }
            }
        }
    }
}