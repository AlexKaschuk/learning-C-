using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Aplication app = Aplication.Instance(); 
            app.ShowMsg("Hello");
            app.Style = Style.circular;
            app.ShowMsg("Hello");

            Aplication app1 = Aplication.Instance();

            app1.ShowMsg("afafa");

            Console.WriteLine(ReferenceEquals(app, app1));

        }
    }
}
