using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class RectCreator : Creator
    {
        public override Button CreateButton() =>
            new RectButton { Text = "OK" };

    }
}
