using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class ExtentionMethods
    {
        public static IDictionary<string, int> WordStatistic(this String str, params char[] delimiters) {
            string[] words = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> Statistics = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (Statistics.ContainsKey(w)) Statistics[w]++;
                else Statistics.Add(w, 1);
            }
            return Statistics;
        }





    }
}
