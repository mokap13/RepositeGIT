using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    public abstract class DuckBase
    {
        public abstract void Display();
        public virtual void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
        public void Swim()
        {
            Console.WriteLine("I'm swiming");
        }
        public virtual void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
