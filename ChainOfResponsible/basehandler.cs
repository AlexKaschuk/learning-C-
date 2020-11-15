using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsible
{
    public abstract class BaseHandler : IAutorizeHandler
    {
        public UserData Users { get; set; }

        private IAutorizeHandler next;
        public virtual bool Handle(params string[] AutorizeData) => next?.Handle(AutorizeData)??true;
       
        public void NextHandler(IAutorizeHandler handler) => next = handler;
       
    }
}
