using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   public delegate void TaskDelegate(string task);


    public class PM: Emloyee
    {

        public void SendTask(string task) => OnTaskEvent(task);

        public event TaskDelegate TaskEvent;
 
        protected void OnTaskEvent(string task) =>
            TaskEvent?.Invoke(task);
        



    }
}
