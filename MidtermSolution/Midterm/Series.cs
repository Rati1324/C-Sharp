using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Series
    {
        private List<Pair[]> series;
        public Series(List<Pair[]> series)
        {
            this.series = series;
        }

        public void Iterate()
        {
            foreach (var item in series)
            {
                Console.WriteLine(item);
            }
        }



    }
}
