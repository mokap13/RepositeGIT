using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    class GreenDuck:DuckBase,IQuackable,IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Hello! I'm Green Duck");
        }

        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
