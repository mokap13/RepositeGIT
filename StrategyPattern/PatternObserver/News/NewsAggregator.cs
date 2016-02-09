using PatternObserver.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.News
{
    class NewsAggregator:ISubject
    {
        private static Random _random;
        private List<IObserver> _observers;
        /// <summary>
        /// Хранит все подписанные приложения
        /// </summary>
        public NewsAggregator()
        {
            _random = new Random();
            _observers = new List<IObserver>();
        }
        /// <summary>
        /// Подписка на новости
        /// </summary>
        /// <param name="observer">Приложение отображающее появляющиеся новости</param>
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        /// <summary>
        /// Отписка от новостей
        /// </summary>
        /// <param name="observer">Приложение отображающее появляющиеся новости</param>
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        /// <summary>
        /// Обновление информации(новостей) в подписанных приложениях
        /// </summary>
        public void NotifyObservers()
        {
            string twitter = GetTwitNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            foreach (var observer in _observers)
            {
                observer.Update(twitter,lenta,tv);
            }
        }

        /// <summary>
        /// Эмуляция новостей
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Обновить новости
        /// </summary>
        public void NewNewsAvailable()
        {
            NotifyObservers();
        }
    }
}
