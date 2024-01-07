using AngeredSimulator.Logic;
using AngeredSimulator.Models;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AngeredSimulator
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int key);
        static void Main()
        {
            Console.WriteLine("To start pres alt+Enter");
            while (true)
            {
                bool altKeyPressed = (GetAsyncKeyState(0xA4) & 0x8000) != 0 || (GetAsyncKeyState(0xA5) & 0x8000) != 0;
                bool enterKeyPressed = (GetAsyncKeyState(0x0D) & 0x8000) != 0;
                if(altKeyPressed && enterKeyPressed)
                {
                    Console.Clear();
                    break;
                }
            }
            ItemLists.Seed();

            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine();

            var manager = new Manager(new Player(name, 100, 2,10,50));
            manager.RunGame();
            
        }
    }
}
