using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.HealthRecovery
{
    class FastHealthRecovery:IHealthRecovery
    {
        public void HealthRecovery()
        {
            Console.WriteLine("I'm FAST health recovering!");
        }
    }
}
