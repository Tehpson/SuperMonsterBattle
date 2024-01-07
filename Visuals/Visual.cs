using AngeredSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AngeredSimulator.Visuals
{
    internal class Visual
    {
        private static int StatBarBoxWidth;
        private static readonly int StatBarMargin = (int)(Console.WindowWidth * 0.1);

        public static void DrawStatusBar(Player player)
        {
            StatBarBoxWidth = (int)(Console.WindowWidth * 0.8 / 4);

            Console.Clear();

            DrawBoxWithText(StatBarMargin, 0, StatBarBoxWidth, 3, new string[1] { $"Strength: {player.Damage}" });
            DrawBoxWithText(StatBarMargin + StatBarBoxWidth, 0, StatBarBoxWidth, 3, new string[1] { $"Health: {player.HP}" });
            DrawBoxWithText(StatBarMargin + (StatBarBoxWidth * 2), 0, StatBarBoxWidth, 3, new string[1] { $"Exp: {player.Exp}" });
            DrawBoxWithText(StatBarMargin + (StatBarBoxWidth * 3), 0, StatBarBoxWidth, 3, new string[1] { $"Money: {player.Money}" });
        }

        internal static void DrawSilkRoad(List<DrugItem> inStorage, int selectedBox)
        {
            Console.SetCursorPosition((int)(Console.WindowWidth * 0.1), 4);
            Console.Write("SILKROAD - Evrythin you want to great price ");
            for (int i = 0; i < inStorage.Count; i++)
            {
                DrawBoxWithText(StatBarMargin,
                                3 * (i + 1) + 2  ,
                                (int)(Console.WindowWidth * 0.8),
                                3,
                                [$" Name: {inStorage[i].Name}  |  Amount: {inStorage[i].Amount}  |  BuyPrice: {inStorage[i].BuyPrice}  |  Predicted sell price: {inStorage[i].SellPrice} "],
                                selectedBox == i ? ConsoleColor.DarkGray : ConsoleColor.White);

            }
        }

        internal static void DrawMenu()
        {
            int menuCardWith = Console.WindowWidth / 4;
            int menuHigth = 3;
            DrawBoxWithText(Console.WindowWidth / 6 - menuCardWith / 2, 10, menuCardWith, menuHigth, new string[1] { "Press 1 to take a nap" });
            DrawBoxWithText(Console.WindowWidth / 6 * 3 - menuCardWith / 2, 10, menuCardWith, menuHigth, new string[1] { "Press 2 to visit Urban Modern" });
            DrawBoxWithText(Console.WindowWidth / 6 * 5 - menuCardWith / 2, 10, menuCardWith, menuHigth, new string[1] { "Press 3 to sell drugs on the street" });
            DrawBoxWithText(Console.WindowWidth / 6 - menuCardWith / 2, 16, menuCardWith, menuHigth, new string[1] { "Press 4 to steal drugs" });
            DrawBoxWithText(Console.WindowWidth / 6 * 3 - menuCardWith / 2, 16, menuCardWith, menuHigth, new string[1] { "Press 5 to Browse silkroad" });
            DrawBoxWithText(Console.WindowWidth / 6 * 5 - menuCardWith / 2, 16, menuCardWith, menuHigth, new string[1] { "Press E to look at you stash" });
        }

        internal static void DrawInventory(Player player)
        {
            int BoxWidth = 10;
            int boxHight = 5;
            int boxRow = 1;
            int boxColumn = 1;
            int boxesARow = 6;

            Console.SetCursorPosition((int)(Console.WindowWidth * 0.1), 4);
            Console.Write("INVENTORY");

            Console.SetCursorPosition((int)(Console.WindowWidth * 0.1), (int)(Console.WindowHeight * 0.9));
            Console.Write("Press esc to exit inventory");

            for (int i = 0; i < 30; i++)
            {
                if (boxColumn > boxesARow)
                {
                    boxColumn = 1;
                    boxRow++;
                }
                DrawBoxWithText(Console.WindowWidth / (boxesARow + 1) * boxColumn - BoxWidth / 2,
                                boxRow * boxHight + boxRow,
                                BoxWidth,
                                boxHight,
                                player.Stash.Count > i ? [player.Stash[i].Amount.ToString(), player.Stash[i].Name] : [""]
                                );

                boxColumn++;
            }
        }

        public static void DrawBoxWithText(int startX, int startY, int width, int highth, string[] text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;

            //Draw to of box
            Console.SetCursorPosition(startX, startY);
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }

            //Draw buttomn of box
            Console.SetCursorPosition(startX, startY + highth - 1);
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            //draw left side of box
            for (int i = 1; i < highth - 1; i++)
            {
                Console.SetCursorPosition(startX, startY + i); Console.Write("|");
            }

            //Draw text
            for (int i = 0; i < text.Length; i++)
            {
                Console.SetCursorPosition(startX + width / 2 - text[i].Length / 2, startY + 1 + i); Console.Write(text[i]);
            }

            //draw rigthside of box
            for (int i = 1; i < highth - 1; i++)
            {
                Console.SetCursorPosition(startX + width, startY + i); Console.Write("|");
            }


            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void DrawBoxWithText(int startX, int startY, int width, int highth, string Text)
        {
            var stringarray = new string[1];
            stringarray[0] = Text;
            DrawBoxWithText(startX, startY, width, highth, stringarray);
        }

        internal static void DrawCenterdBoxWithText(List<string> texts)
        {
            int longestLength = texts.Max(x=> x?.Length ?? 0);
            var textOffset = longestLength / 2 + 1;
            DrawBoxWithText(Console.WindowWidth / 2 - textOffset + 5, Console.WindowHeight /2  - 1, longestLength +3, texts.Count+2, texts.ToArray());
        }
        internal static void DrawCenterdBoxWithText(string text)
        {
            DrawCenterdBoxWithText(new List<string> { text });
        }
    }
}