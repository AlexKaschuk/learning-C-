using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in SequenceGenerator.GenerateRandomSequence<int>(10, -50, 100, new RandomAdapter())) {
                Console.Write($"{item} ");
            };












        }
    }
}
