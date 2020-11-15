using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    abstract class Creator
    {
        public abstract Button CreateButton();

        public void Show(string msg) {
            Button b = CreateButton();
            Console.WriteLine(msg);
            b.Render();
        }
    }
}
