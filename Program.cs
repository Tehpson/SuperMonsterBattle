using SuperMonsterBattle.Logic;
using SuperMonsterBattle.Models;
using System;

namespace SuperMonsterBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            Console.SetBufferSize(150, 50);
            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine();
            var manager = new Manager(new Player(name, 100, 2, 10));
            manager.RunGame();
            
        }
    }
}
