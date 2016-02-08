using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    class RubberDuck:DuckBase,IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Hello! I'm Rubber Duck!");
        }
        
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
