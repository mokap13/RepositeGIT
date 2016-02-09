using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.HealthRecovery
{
    class SimpleHealthRecovery:IHealthRecovery
    {
        public void HealthRecovery()
        {
            Console.WriteLine("I'm simple health recovering");
        }
    }
}
