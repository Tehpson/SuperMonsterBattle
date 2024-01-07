using AngeredSimulator.Models;
using AngeredSimulator.Visuals;
using System;
using System.Collections.Generic;

namespace AngeredSimulator.Logic
{
    class DrugRun
    {
        public static int DrugRunCounter = 0;
        public static void Run(Player player)
        {
            List<DrugItem> soldDrugs = new List<DrugItem>();
            int AinaProb = CalculateProbablityToEncunterAina(player);
            int GangProb = CalculateProbablityToEncunterGang(player);
            var rand = new Random();
            bool EncouterAina = rand.Next(100) < AinaProb; 
            bool EncouterGang = rand.Next(100) < GangProb; 
            if (!EncouterAina && !EncouterGang)
            {
                foreach(var item in player.Stash)
                {
                    for (int i = 0; i < item.Amount; i++)
                    {
                        if (rand.Next(100) < item.Wanted) soldDrugs.Add(item);
                    }
                }
                
                var profit = CalculateProfite(soldDrugs);
                Visual.DrawCenterdBoxWithText($"you sold for: {profit}");
                player.Money += profit;
                foreach (var item in soldDrugs)
                {
                    var drugInStash = player.Stash.Find(x => x.Name == item.Name);

                    if (drugInStash.Amount > 1) drugInStash.Amount--; else player.Stash.Remove(drugInStash);
                }
            }
            else if (EncouterAina)
            {
                player.Stash.Clear();
                Visual.DrawCenterdBoxWithText( new List<string> { "Shorri rullade förbi med sin piket", "för att inte bli nerslagen så slängde du allt ditt stash i en soptunna i närheten...", "Bra jobbat du har förloart allt" });
            }
            DrugRunCounter++;
        }

        private static int CalculateProbablityToEncunterAina(Player player) => Math.Min((int)Math.Floor((decimal)(DrugRunCounter / 5)), 80);
        private static int CalculateProbablityToEncunterGang(Player player) => Math.Min((int)Math.Floor((decimal)(DrugRunCounter / 5)), 80);
        private static uint CalculateProfite(List<DrugItem> SoldList)
        {
            uint profit = 0;
            var ran = new Random();
            foreach (var item in SoldList)
            {
                    var r = ran.Next(95, 105);
                    decimal flux = r / 100m;
                    profit += (uint)(item.SellPrice * flux);
            }
            return profit;
        }
    }
}
