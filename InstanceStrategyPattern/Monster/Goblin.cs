using InstanceStrategyPattern.HealthRecovery;
using InstanceStrategyPattern.Strike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.Monster
{
    class Goblin:MonsterBase
    {
        public Goblin()
        {
            strikeBehiviour = new WeakStrike();
            recovBehiviour = new SimpleHealthRecovery();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm Goblin!");
        }
    }
}
