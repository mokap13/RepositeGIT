using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.Strike
{
    class WeakStrike:IStrike
    {
        public void Strike()
        {
            Console.WriteLine("I'm weak striking...");
        }
    }
}
