using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Widgets
{
    class TvWidget:IObserver
    {
        private string _tv;

        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;
        }

        public void Display()
        {
            Console.WriteLine("Tv:{0}", _tv);
        }
    }
}
