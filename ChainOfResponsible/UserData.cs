using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsible
{
    public class UserData
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        public void AddUser(string login, string pass) => users.Add(login, pass);

        public bool CheckLogin(string login) => users.ContainsKey(login);
        public bool CheckPass(string login, string pass)=> users[login]==pass;

    }
}
