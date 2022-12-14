using SuperMonsterBattle.Models;
using SuperMonsterBattle.Visuals;
using System;

namespace SuperMonsterBattle.Logic
{
    class Manager
    {
        private readonly Player player;
        private readonly StoreManager storeManager = new StoreManager();
        private readonly SilkRoad silkRoad = new SilkRoad();
        private State state = new State();

        public Manager (Player player)
        {
            this.player = player;
            state = State.Menu;



            using var urbanTimer = new System.Timers.Timer(60000 * 60);
            urbanTimer.Elapsed += (sedner, e) => storeManager.UpdateStore();
            urbanTimer.Start();
            urbanTimer.AutoReset = true;


            using var SilkRoadtimer = new System.Timers.Timer(60000 * 20);
            SilkRoadtimer.Elapsed += (sedner, e) => silkRoad.UpdateSilkRoad();
            SilkRoadtimer.Start();
            SilkRoadtimer.AutoReset = true;


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
                        DrugRun.Run(player);
                        Console.ReadKey();
                        state = State.Menu;
                        break;
                    case State.SilkRoad:
                        SilkRoad();
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

        private void SilkRoad()
        {
            silkRoad.VisitSilkRoad(player,ref state);
        }

        private void Inventory()
        {
            Visual.DrawInventory(player);
            if(Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                state = State.Menu;
            
            }
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
                        state = State.SilkRoad;
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
        SilkRoad,
        StealRun,
        Fight,
        Rest,
        Urban,
    }
}
