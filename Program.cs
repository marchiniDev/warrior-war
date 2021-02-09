using System;
using System.Threading;
using WarriorWar.Enum;

namespace WarriorWar
{
    class Program
    {
        static Random rng = new Random();
        
        static void Main()
        {
            Warrior goodGuy = new Warrior("Renan", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Marchini", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,1) == 1)
                {
                    goodGuy.Attack(badGuy);                    
                } 
                else 
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(500);
            }            
        }
    }
}
