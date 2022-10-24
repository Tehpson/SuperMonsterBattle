using SuperMonsterBattle.Logic;
using SuperMonsterBattle.Models;
using System;
using System.Threading.Tasks;

namespace SuperMonsterBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 40);
            Console.SetBufferSize(150, 40);
            ItemLists.Seed();

            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine();
            var manager = new Manager(new Player(name, 100, 20,10,0, 50));
            manager.RunGame();
            
        }
    }
}
