using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstanceStrategyPattern.Monster;

namespace InstanceStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MonsterBase> Monsters = new List<MonsterBase>();
            Monsters.Add(new MonsterOrc());
            Monsters.Add(new MonsterTroll());
            Monsters.Add(new Goblin());

            foreach (var Monster in Monsters)
            {
                Monster.Display();
                Monster.Strike();
                Monster.HealthRecovery();

                Console.WriteLine("----------------");
            }

            Console.ReadKey();
        }
    }
}
