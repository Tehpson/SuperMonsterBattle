using SuperMonsterBattle.Models;
using System;

namespace SuperMonsterBattle.Visuals
{
    internal class Visual
    {
        private static int StatBarBoxWidth;
        private static readonly int StatBarMargin = (int)(Console.WindowWidth * 0.1);

        public static void DrawStatusBar(Player player)
        {
            StatBarBoxWidth = (int)(Console.WindowWidth * 0.8 / 4);

            Console.Clear();
            Console.SetCursorPosition(StatBarMargin, 0);

            for (int i = 0; i < Console.WindowWidth * 0.8; i++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(StatBarMargin, 2);

            for (int i = 0; i < Console.WindowWidth * 0.8; i++)
            {
                Console.Write("-");
            }
            DrawStat(1, "Strength:", player.Damage.ToString());
            DrawStat(2, "Health:", player.HP.ToString());
            DrawStat(3, "Exp:", player.Exp.ToString());
            DrawStat(4, "Money:", player.Money.ToString());
        }

        private static void DrawStat(int pos, string StatName, string value)
        {
            int statlength = StatName.Length + value.Length + 2;

            Console.SetCursorPosition((StatBarBoxWidth * pos) - StatBarBoxWidth + StatBarMargin, 1);
            Console.Write("|");
            Console.SetCursorPosition(StatBarBoxWidth * pos - ((StatBarBoxWidth / 2) + (statlength / 2)) + StatBarMargin, 1);
            Console.Write(StatName + " " + value);
            Console.SetCursorPosition((StatBarBoxWidth * pos) + StatBarMargin - 1, 1);
            Console.Write("|");
        }

        internal static void DrawMenu()
        {
            int menuCardWith = Console.WindowWidth / 4;
            DrawMenuCard(Console.WindowWidth / 6 - menuCardWith / 2, 10, menuCardWith, "Press 1 to take a nap");
            DrawMenuCard(Console.WindowWidth / 6 * 3 - menuCardWith / 2, 10, menuCardWith, "Press 2 to visit Urban Modern");
            DrawMenuCard(Console.WindowWidth / 6 * 5 - menuCardWith / 2, 10, menuCardWith, "Press 3 to sell drugs on the street");
            DrawMenuCard(Console.WindowWidth / 6 - menuCardWith / 2, 16, menuCardWith, "Press 4 to steal drugs");
            DrawMenuCard(Console.WindowWidth / 6 * 3 - menuCardWith / 2, 16, menuCardWith, "Press 5 to take a drug delivery");
            DrawMenuCard(Console.WindowWidth / 6 * 5 - menuCardWith / 2, 16, menuCardWith, "Press E to look at you stash");
        }

        private static void DrawMenuCard(int startX, int startY, int width, string text)
        {
            Console.SetCursorPosition(startX, startY);
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(startX, startY + 2);
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(startX, startY + 1); Console.Write("|");
            Console.SetCursorPosition(startX + width / 2 - text.Length / 2, startY + 1); Console.Write(text);
            Console.SetCursorPosition(startX + width, startY + 1); Console.Write("|");
        }
    }
}