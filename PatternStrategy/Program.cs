﻿using System;
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

            foreach (var item in Ducks)
            {
                item.Display();
                item.Quack();
                item.Swim();
                item.Fly();
                Console.WriteLine("---------------------");
            }
            Console.ReadKey();
        }
    }
}
