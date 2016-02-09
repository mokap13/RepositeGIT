using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver2
{
    class Program
    {
        delegate int Opperation(int x, int y);

        static void Main(string[] args)
        {
            Opperation del;

            
            int choose = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choose) == false)
                {
                    Console.WriteLine("Error");
                    continue;
                }
                
                if (choose == 1)
                {
                    del = Add;
                }
                else
                {
                    del = Multiply;
                }

                Console.WriteLine(del.Invoke(4, 5));
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
