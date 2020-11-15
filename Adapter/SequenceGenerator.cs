using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public static class SequenceGenerator
    {
        public static IEnumerable<T> GenerateRandomSequence<T>(int length, T from, T to, IRandomble<T> gen) {
            List <T> list = new List<T>();
            for (int i = 0; i < length; ++i) {
                list.Add(gen.RandomValue(from, to));
            }

            return list;
        } 




    }
}
