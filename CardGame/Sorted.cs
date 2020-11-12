using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Sorted : IComparer<Card>
    {
        public int Compare(Card x, Card y) => x.Rank.CompareTo(y.Rank);
        
    }
}
