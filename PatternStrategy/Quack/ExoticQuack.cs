using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Quack
{
    class ExoticQuack:IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
