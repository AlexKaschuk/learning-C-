using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Team
    {
        public PM Pm { get;  private set; }

        public List<Performer> Performers = new List<Performer>();


        public void Add(Emloyee any)
        {
            if (any is PM) Pm = any as PM;
            if (any is Performer) Performers.Add(any as Performer);

            if (Pm != null)
                  Pm.TaskEvent += (any as Performer).GetTask;
            
        }


    }
}
