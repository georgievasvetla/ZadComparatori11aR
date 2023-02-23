using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadCompiatoriOL
{
    internal class ICompratorTochki : IComparer<Olimpiada>
    {
        public int Compare(Olimpiada x, Olimpiada y)
        {
            return x.Tochki.CompareTo(y.Tochki);
        }
    }
}
