using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class RectCreator : Creator
    {
        public override Button CreateButton()=>
            new RectButton { Text = "OK"};
       
    }

    class CircleCreator : Creator
    {
        public override Button CreateButton() =>
            new CircleButton { Text = "OK" };

    }
}
