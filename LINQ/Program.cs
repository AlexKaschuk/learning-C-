using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //string str = "Hello, world!";
                //foreach (KeyValuePair<string, int> pair in str.WordStatistic(',', '!',' ')) 
                //    Console.WriteLine($"key: {pair.Key}\tvalue: {pair.Value}");


                //1
                //List<int>arr = new List<int> { -13, -19, 7, 7, 5, -13, 7, -19, 12, -171, 5 };
                //Console.WriteLine(arr?.First(x => x > 0));
                //Console.WriteLine(arr?.Last(x => x < 0));
                // IEnumerable<int> s = arr.Where(x => x < 0)
                //     .OrderBy(x=>Math.Abs(x).ToString().Aggregate(0, (sum, digit)=>sum + Convert.ToInt32(digit.ToString())));
                // IEnumerable<int> s1 = arr.Where(x => x < 0)
                //     .OrderBy(x => Math.Abs(x).ToString().Select(digit => Convert.ToInt32(digit.ToString())).Sum());


                //var sss = from number in arr 
                //              where number < 0 orderby Math.Abs(number)%10 
                //              select new {number, countD = Math.Abs(number).ToString().Count() };

                // var sss1 = from number in arr
                //           where number < 0
                //           orderby Math.Abs(number) % 10
                //           select new { number, countD = Math.Abs(number).ToString().Distinct().Count() };


                //arr.Add(-78);
                //foreach (var i in sss1)
                //    Console.WriteLine($"{i} ");


                //var groupP = arr.GroupBy(x => x).Select(g => new { g.Key, countElements = g.Count()});
                //int z = arr.GroupBy(x => x).Select(g => new { g.Key, countElements = g.Count() }).Where(x=>x.countElements>1).Count();
                //foreach (var item in groupP)
                //    Console.WriteLine(item);
                //Console.WriteLine(z);
                //3

                //int L = 5;
                //String[] strArr = { "Hello", "world", "4opapapa" };
                //Console.WriteLine(strArr.LastOrDefault(x => char.IsDigit(x[0]) && x.Length == L)??"not found"); 

            } //linq


            //Performer Im = new Performer
            //{
            //    Name = "Alex",
            //    Tasks = new List<string> { "T1", "T2" }
            //};
            //Console.WriteLine(Im);

            //PM pm = new PM{Name = "Vasja"};

            //pm.TaskEvent += new TaskDelegate(Im.GetTask);
            //pm.SendTask("Move out");
            //Console.WriteLine(Im);




            Aplication a = new Aplication();
            a.Style = Style.circular;
            a.ShowMsg("Hello");


        }

       
    }
}
