using PatternObserver.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.News
{
    class NewsAggregator
    {
        private static TwitWidget _twitWidget;
        private static TvWidget _tvWidget;
        private static LentaWidget _lentaWidget;
        private static Random _random;

        public NewsAggregator()
        {
            _twitWidget = new TwitWidget();
            _tvWidget = new TvWidget();
            _lentaWidget = new LentaWidget();
            _random = new Random();
        }

        public string GetTwitNews()
        {
            var news = new List<string>
            {
                "Новость из Twitter номер 1",
                "Новость из Twitter номер 2",
                "Новость из Twitter номер 3"
            };

            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>{
                "Новость из Tv номер 1",
                "Новость из Tv номер 2",
                "Новость из Tv номер 3"
            };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>(){
                "Новость из Lenta номер 1",
                "Новость из Lenta номер 2",
                "Новость из Lenta номер 3"
            };

            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            string twitter = GetTwitNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            _twitWidget.Update(twitter, lenta, tv);
            _tvWidget.Update(twitter, lenta, tv);
            _lentaWidget.Update(twitter, lenta, tv);
        }
    }
}
