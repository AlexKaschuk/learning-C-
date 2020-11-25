using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> li = new List<int> { -13, -19, 7, -4, 5, -13, 7, -19, 12, -171, 5, -12, -14 };
            // Console.WriteLine(li?.First(x => x > 0));
            //Console.WriteLine(li?.Last(x => x < 0));

            //2
            //int item = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(li.FirstOrDefault(x => x>0 && (Math.Abs(x)==item || Math.Abs(x) % 10==item)));

            //3
            //int L = 5;
            //String[] strArr = { "Hello", "dworld", "4opapapa", "dworld", };
            //Console.WriteLine(strArr.LastOrDefault(x => char.IsDigit(x[0]) && x.Length == L) ?? "not found");

            //4
            //char c = 'd';
            //Console.WriteLine(strArr.Where(x => x[x.Length-1]==c).Count()>1?"error"
            //    : strArr.Where(x => x[x.Length - 1] == c).Count() == 1? strArr.First(x => x[x.Length - 1] == c) : "");

            //5

            //char c = 'd';
            //int z = strArr.Where(x => x.Length>1&&x[x.Length - 1] == c && x[0] == c).Count();
            //Console.WriteLine(z);

            //6

            //int s = strArr.Aggregate(0, (sum, next) => sum += next.Length);
            //Console.WriteLine(s);

            //7

            //Console.WriteLine(li.Where(x=>x<0).Count()==0 ? "0\n0" 
            //    : $"quantity negative numbers: {li.Where(x => x < 0).Count()} sum: {li.Where(x => x < 0).Sum()}");

            //8
            //Console.WriteLine(li.Where(x => (double)x/10 >= 1).Count() == 0 ? $"{0}\n{(double)0}" 
            //    : $"quantity positive numbers: {li.Where(x => x > 0).Count()} average: {(double)li.Where(x => x > 0).Average()}");

            //9
            // Console.WriteLine(li.Where(x => x > 0).Count() > 1 ? li.Where(x => x > 0).Min() : 0);


            //10
            //int LL = 4;
            //String[] strArr2 = { "HELLO", "MAMA", "TATOOO", "ANCL" };
            //Console.WriteLine(strArr2.Where(x=>x.Length==LL).Count()>0? strArr2.Where(x => x.Length == LL).Max():"");


            //11
            //string nn = strArr.Aggregate("", (sum, next) => sum += next[0]);
            //Console.WriteLine(nn);

            //12
            //Console.WriteLine(li.Aggregate(1.0, (sum, next) => sum *= next % 10 > 1|| next % 10 < -1 ? next % 10 : 1)) ;

            //13
            //int m = 9;
            //Console.WriteLine(Enumerable.Range(1, m).Select(x=>(double)1/x).Sum());

            //14
            //int A = 2, B = 8;
            //Console.WriteLine(Enumerable.Range(A, B - 1).Select(next => next * next).Average());

            //15
            //int N = 6;
            //Console.WriteLine(Enumerable.Range(0, N+1).Aggregate(1, (sum, next) => next==0 ? 1:sum *= next));



            //16
            //List<int> arr22 = li.Where(x => x > 0).ToList();
            //foreach (int i in arr22)
            //    Console.WriteLine(i);

            //17
            //List<int> neg = li.Distinct().Where(x=>x<0).ToList();
            //foreach (int i in neg)
            //     Console.WriteLine(i);

            //18
            //List<int> revNeg = li.Where(x => x < 0 && x % 2 == 0).Reverse().ToList();
            //foreach (int i in revNeg)
            //    Console.WriteLine(i);

            //19
            //int D = 3;
            List<int> someName = new List<int> { 1, 3, 13, 133, 15, -25, 48, 43, 16, 13, 13, 18, 133 };
            //List<int> someAlseName = someName.Where(x => x % 10 == D).Reverse().Distinct().Reverse().ToList();
            //foreach (int i in someAlseName)
            //    Console.WriteLine(i);

            //20
            //List<int> ZZZ = someName.Where(x => x > 0&&x>10&&x<100).ToList();
            //ZZZ.Sort();
            //foreach (int i in ZZZ)
            //    Console.WriteLine(i);


            //21

            //List<string> dd = new List<string> { "HELLO", "MAMA", "TATOOO", "ANCL" };
            //dd.Sort((x, y)=> x.Length==y.Length?x.CompareTo(y):x.Length.CompareTo(y.Length));
            //foreach (string i in dd)
            //    Console.WriteLine(i);

            //22

            // int K = 7;
            List<string> vvv = new List<string> { "1HELLO1", "TATOO!1", "AMAMA11", "ANCL" };
            // List<string> vv1 = vvv.Where(x => x.Length == K && char.IsDigit(x[x.Length - 1])).ToList();
            // vv1.Sort((x, y) => x.CompareTo(y));
            // foreach (string i in vv1)
            //     Console.WriteLine(i); 


            //23
            //int KK = 3;
            //List<int> mmm = li.GetRange(KK, li.Count() - KK).Where(x => x < -9 && x > -100).ToList();
            //mmm.Sort((x, y) => y.CompareTo(x));
            //foreach (int i in mmm)
            //    Console.WriteLine(i);


            //24
            //int ppp = 3;
            //List<string> ddddd = vvv.GetRange(0, ppp).Where(x => char.IsUpper(x[0]) && x.Length % 2 == 1).Reverse().ToList();
            //foreach (string i in ddddd)
            //    Console.WriteLine(i);

            //25
            //int KKK1 = 2, KKK2 = 6;
            //Console.WriteLine(li.GetRange(KKK1, KKK2-KKK1+1).Where(x=>x>0).Sum());
            //Console.WriteLine(li.GetRange(KKK1, KKK2-KKK1+1).Where(x=>x>0).Sum());



            int x = 2, y = 1024;
            Console.WriteLine();

        }
    }
}
