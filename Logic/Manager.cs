using SuperMonsterBattle.Models;
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
                Visuals.Visual.Draw(player);
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
            Console.Read();
        }


    }
    public enum State
    {

        Menu,
        DrugRun,
        Delivery,
        StealRun,
        Fight,
        Rest,
        Urban,
    }
}
