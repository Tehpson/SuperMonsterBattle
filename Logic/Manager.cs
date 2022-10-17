using SuperMonsterBattle.Models;
using SuperMonsterBattle.Visuals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMonsterBattle.Logic
{
    class Manager
    {
        private readonly Player player;
        private readonly StoreManager storeManager;
        private State state = new State();

        public Manager (Player player)
        {
            this.player = player;
            state = State.Menu;



            using var timer = new System.Timers.Timer(60000 * 60);
            timer.Elapsed += (sedner, e) => storeManager.UpdateStore();
            timer.Start();
            timer.AutoReset = true;


        }

        internal void RunGame()
        {
            while (true)
            {
                Visual.DrawStatusBar(player);
                if (storeManager.NextUpdate < DateTime.Now) storeManager.UpdateStore();

                switch (state)
                {
                    case State.Menu:
                        Menu();
                        break;
                    case State.Urban:
                        storeManager.VisitStore();
                        break;
                    case State.Rest:
                        Rest();
                        break;
                    case State.Inventory:
                        Inventory();
                        break;
                    case State.DrugRun:
                        DrugRun();
                        break;
                    case State.Delivery:
                        Delivery();
                        break;
                    case State.StealRun:
                        Steal();
                        break;
                    case State.Fight:
                        Figth();
                        break;
                }
            }
        }

        private void Figth()
        {
            throw new NotImplementedException();
        }

        private void Steal()
        {
            throw new NotImplementedException();
        }

        private void Delivery()
        {
            throw new NotImplementedException();
        }

        private void DrugRun()
        {
            throw new NotImplementedException();
        }

        private void Inventory()
        {
            throw new NotImplementedException();
        }

        private void Rest()
        {
            throw new NotImplementedException();
        }

        private void Menu()
        {
            Visual.DrawMenu();
            Console.SetCursorPosition(0, 0);
            while (true)
            {
                //Upadete to be a interactive menu instead of keypress
                switch (Console.ReadKey(true).Key)
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
