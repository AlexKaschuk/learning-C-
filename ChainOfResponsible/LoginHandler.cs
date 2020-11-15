using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsible
{
    public class LoginHandler:BaseHandler
    {
        public override bool Handle(params string[] AutorizeData) => 
            Users.CheckLogin(AutorizeData[0]) && base.Handle(AutorizeData);

    }

    public class PassHandler : BaseHandler
    {
        public override bool Handle(params string[] AutorizeData) =>
            Users.CheckPass(AutorizeData[0], AutorizeData[1])&&base.Handle(AutorizeData);
    }
}
