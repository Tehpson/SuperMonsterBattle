using SuperMonsterBattle.Models;
using SuperMonsterBattle.Visuals;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMonsterBattle.Logic
{
    class Manager
    {
        private readonly Player player;
        private State state = new State();

        public Manager (Player player)
        {
            this.player = player;
            state = State.Menu;
        }

        internal void RunGame()
        {
            while (true)
            {
                Visual.DrawStatusBar(player);
                switch (state)
                {
                    case State.Menu:
                        Menu();
                        break;

                }
            }
        }

        private void Menu()
        {
            Visual.DrawMenu();
            Console.SetCursorPosition(0, 0);
            while (true)
            {
                //Upadete to be a interactive menu instead of keypress
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        state = State.Rest;
                        return;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        state = State.Urban;
                        return;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        state = State.DrugRun;
                        return;

                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        state = State.StealRun;
                        return;

                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        state = State.Delivery;
                        return;

                    case ConsoleKey.E:
                        state = State.Inventory;
                        return;
                }
            }
        }
    }
    public enum State
    {

        Menu,
        Inventory,
        DrugRun,
        Delivery,
        StealRun,
        Fight,
        Rest,
        Urban,
    }
}
