using InstanceStrategyPattern.HealthRecovery;
using InstanceStrategyPattern.Strike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.Monster
{
    class MonsterTroll:MonsterBase
    {
        public MonsterTroll()
        {
            strikeBehiviour = new StrongStrike();
            recovBehiviour = new FastHealthRecovery();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm Troll!!!");
        }
    }
}
