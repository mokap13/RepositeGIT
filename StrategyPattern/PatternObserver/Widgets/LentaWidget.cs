using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Widgets
{
    class LentaWidget:IObserver
    {
        private string _lenta;

        public void Update(string twitter, string lenta, string tv)
        {
            _lenta = lenta;
        }

        public void Display()
        {
            Console.WriteLine("Lenta:{0}", _lenta);
        }
    }
}
