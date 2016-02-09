using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.Strike
{
    class StrongStrike:IStrike
    {
        public void Strike()
        {
            Console.WriteLine("I'm STRONG striking!!!");
        }
    }
}
