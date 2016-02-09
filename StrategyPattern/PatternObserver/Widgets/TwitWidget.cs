using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Widgets
{
    class TwitWidget
    {
        public void Update(string twitter, string lenta, string tv)
        {
            Console.WriteLine("Twitter:{0}", twitter);
        }
    }
}
