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
        
        public void Swim()
        {
            Console.WriteLine("I'm swiming");
        }
    }
}
