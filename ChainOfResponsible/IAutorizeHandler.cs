using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsible
{
    public interface IAutorizeHandler
    {
        void NextHandler(IAutorizeHandler handler);

        bool Handle(params string[] AutorizeData);

    }
}
