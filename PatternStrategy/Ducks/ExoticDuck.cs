using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    class ExoticDuck:DuckBase
    {
        public override void Display()
        { 
            Console.WriteLine("Hello! I'm Exotic Duck");
        }
    }
}
