using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Program

    {
        static void Main(string[] args)
        {

            //PrintMsg("Hello world");
            //PrintDecorMsg("Hello world");

            // MsgDelegate Md;
            // Md = new MsgDelegate(PrintDecorMsg);
            // Md += new MsgDelegate(PrintMsg);
            //Md = new MsgDelegate(PrintMsg);
            //Md?.Invoke("Hello world");
            // Md = null;
            //Md?.Invoke("Hello world");


            // Md += Program.PrintMsg;


            // foreach (Delegate item in Md.GetInvocationList())
            //     Console.WriteLine($"{item.Target}\t{item.Method}");


            List<int> li = new List<int> { 1, 2, -3, 4, -5, 6, -7, 8 };


            List<int> Pos = new List<int>();
            //Pos = li.Where(x => x > 0).ToList();


            PredicateT<int> Pt = PosFilter;

            //Pos = li.FindAll(Pt.Invoke);

            //foreach (int i in Pos)
            //    Console.WriteLine(i);
            //Pos = li.Where(Pt.Invoke).ToList(); 
            //Pos = li.Where(new PredicateT<int>(PosFilter).Invoke).ToList();
            //Pos = li.FindAll(x=> x > 0);

            
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Pos = li.Where(x => a < b ? x > a && x < b : x > b && x < a).ToList();

            foreach (int i in Pos)
                Console.WriteLine(i);
            
            Console.WriteLine(Pos.Sum());
            int g = 1;

            li.FindAll(x => x >= a && x <= b).ForEach(x => g *= x);


            Console.WriteLine(g);



        }

        public static void PrintMsg(string Msg) => Console.WriteLine(Msg);

        public static void PrintDecorMsg(string Msg) => Console.WriteLine($"{new string('_', Msg.Length)}\n{Msg}\n{new string('_', Msg.Length)}");

        public static bool PosFilter(int x) => x > 0;




    }
}
