using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class RectButton : Button
    {
        public override void Render()=>
            Console.WriteLine($"[{Text}]");
        
    } 
    
    class CircleButton : Button
    {
        public override void Render()=>
            Console.WriteLine($"({Text})");
        
    }
}
