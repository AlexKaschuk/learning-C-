using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //string path = "1.txt";
            //string path1 = "2.txt";

            //ComparerFiles.CompareFiles(path, path1);

            //task 2



            Employee f = new Employee("Alex", "K", 38099223366);
            Employee g = new Employee("Vasya", "P", 38099223367);
            Console.WriteLine($"{f.Id}: {g.Id}");
            PhoneFinder finder = new PhoneFinder("phone.bin");
            finder.AddEmployee(f, g);
            finder.FindNumber("Peter");
            finder.FindNumber("Alex");
            finder.FindNumber("P");
            finder.FindNumber(1000001);
            finder.SaveNumbers();
            finder.PrintAllNums();


        }
    }
}
