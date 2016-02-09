using PatternObserver.News;
using PatternObserver.Widgets;
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
            var twitWidget = new TwitWidget();
            var lentaWidget = new LentaWidget();
            var tvWidget = new TvWidget();

            newsAggregator.RegisterObserver(twitWidget);
            newsAggregator.RegisterObserver(tvWidget);
            newsAggregator.RegisterObserver(lentaWidget);

            newsAggregator.NewNewsAvailable();
            Console.WriteLine("-----------------------");

            twitWidget.Display();
            tvWidget.Display();
            lentaWidget.Display();

            Console.ReadKey();
        }
    }
}
