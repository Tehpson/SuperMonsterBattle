using SuperMonsterBattle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Logic
{
    class DrugRun
    {

        public static void Run(Player player)
        {
            List<DrugItem> soldDrugs = new List<DrugItem>();
            int AinaProb = 0; //CalculateProbablityToEncunterAina(player);
            int GangProb = 0;//CalculateProbablityToEncunterGang(player);
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
                Console.WriteLine("you sold for:" +profit);
                player.Money += profit;
                foreach (var item in soldDrugs)
                {
                    var drugInStash = player.Stash.Find(x => x.Name == item.Name);

                    if (drugInStash.Amount > 1) drugInStash.Amount--; else player.Stash.Remove(drugInStash);
                }
            }
        }

        private static int CalculateProbablityToEncunterAina(Player player)
        {
            throw new NotImplementedException();
        }
        private static int CalculateProbablityToEncunterGang(Player player)
        {

            throw new NotImplementedException();
        }
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
