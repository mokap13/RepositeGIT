using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Widgets
{
    class TvWidget
    {
        public void Update(string twitter, string lenta, string tv)
        {
            Console.WriteLine("Tv:{0}", tv);
        }
    }
}
