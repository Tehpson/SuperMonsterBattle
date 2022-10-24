using SuperMonsterBattle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Logic
{
    class DrugRun
    {

        public static void PreformDrugRun(Player player)
        {
            List<DrugItem> soldDrugs = new List<DrugItem>();
            int AinaProb = CalculateProbablityToEncunterAina(player);
            int GangProb = CalculateProbablityToEncunterGang(player);
            var rand = new Random();
            bool EncouterAina = rand.Next(100) < AinaProb; 
            bool EncouterGang = rand.Next(100) < GangProb;
            if (EncouterAina)
            {
                ///var aina = new Models.Gang();
            }
            else if (EncouterGang)
            {
                var hp = player.HP*(rand.Next(95,103)/100);
                var damage = player.Damage* (rand.Next(95, 103) / 100);
                var thug = new Thug("Thuggster", hp, (uint)damage, 0);
                Console.WriteLine($"You have encountered{thug.Name}. they have {player.HP} HP");
                Figth(player, thug);
            }
            else
            {
                foreach(var item in player.Stash)
                {
                    Visuals.Visual.DrawStatusBar(player);
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

        private static void Figth(Player player, Thug thug)
        {
            while (!player.Dead && !thug.Dead)
            {
                Console.WriteLine("press 1 to attack");
                var userinput = Console.ReadKey().Key;
                if (userinput == ConsoleKey.D1 || userinput == ConsoleKey.NumPad1)
                {
                    var playerDamage = player.GiveDamage();
                    var playerDamageRaken = thug.TakeDamage(playerDamage);
                    Console.WriteLine($"You did {playerDamageRaken} damage to {thug.Name}");
                    if (!thug.Dead)
                    {
                        var thugDamae = thug.GiveDamage();
                        var thugDamgeTaken = player.TakeDamage(thugDamae);
                        Console.WriteLine($"{thug.Name} did {thugDamgeTaken} damage to {player.Name} ");
                    }
                }
            }
            if (player.Dead)
            {
                Visuals.Visual.DrawGameOver();
            }
            else
            {
                var r = new Random();
                var earndXP = player.Exp * (r.Next(105, 110) / 100);
                player.Exp += (uint)earndXP;
                Console.WriteLine($"You have defeated {thug.Name} and earnd {earndXP} XP");
            }
        }

        private static int CalculateProbablityToEncunterAina(Player player)
        {
            return 0;
        }
        private static int CalculateProbablityToEncunterGang(Player player)
        {
            return 20;
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
