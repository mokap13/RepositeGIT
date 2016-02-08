﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Ducks
{
    class SimpleDuck:DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hello! I'm Simple Duck");
        }
    }
}
