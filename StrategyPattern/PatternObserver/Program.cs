using PatternObserver.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();

            newsAggregator.NewNewsAvailable();
            Console.WriteLine("----------------------------");
            newsAggregator.NewNewsAvailable();

            Console.ReadKey();
        }
    }
}
