using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    class WoodenDuck:DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hello! I'm Wooden Duck");
        }

        public override void Quack()
        {
        }

        public override void Fly()
        {
        }
    }
}
