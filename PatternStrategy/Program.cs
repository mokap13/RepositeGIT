using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStrategy.Ducks;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> Ducks = new List<DuckBase>();
            Ducks.Add(new SimpleDuck());
            Ducks.Add(new ExoticDuck());
            Ducks.Add(new GreenDuck());
            Ducks.Add(new WoodenDuck());
            Ducks.Add(new RubberDuck());

            foreach (var duck in Ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
                Console.WriteLine("---------------------");
            }
            Console.ReadKey();
        }
    }
}
