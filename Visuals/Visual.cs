using SuperMonsterBattle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Visuals
{
    class Visual
    {
        public static void Draw(Player player)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(0, 2);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            DrawStat(1, "Strength:", player.Damage.ToString());
            DrawStat(2, "Health:", player.HP.ToString());
            DrawStat(3, "Exp:", player.Exp.ToString()); 
            DrawStat(4,"Money:", player.Money.ToString());
        }

        private static void DrawStat(int pos, string StatName, string value)
        {
            var boxWidth = Console.WindowWidth / 4;
            int statlength = StatName.Length + value.Length + 2;

            Console.SetCursorPosition((boxWidth * pos)-boxWidth, 1);
            Console.Write("|");
            Console.SetCursorPosition(boxWidth * pos - ((boxWidth / 2) + (statlength / 2)), 1);
            Console.Write(StatName + " " + value);
            Console.SetCursorPosition((boxWidth * pos-1), 1);
            Console.Write("|");

        }
    }
}
