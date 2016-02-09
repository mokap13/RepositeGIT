using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver.Widgets
{
    class LentaWidget
    {
        public void Update(string twitter, string lenta, string tv)
        {
            Console.WriteLine("Lenta:{0}",lenta);
        }
    }
}
