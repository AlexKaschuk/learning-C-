using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class CircleCreator : Creator
    {
        public override Button CreateButton() =>
            new CircleButton { Text = "OK" };

    }
}
