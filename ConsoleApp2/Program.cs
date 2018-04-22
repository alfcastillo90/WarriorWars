using System;
using System.Threading;
using WarriorWars.Enum;
namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();
        static void Main()
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Job", Faction.BadGuy);
            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(100);
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}