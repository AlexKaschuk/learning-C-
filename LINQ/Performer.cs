using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Performer : Emloyee
    {

        public List<string> Tasks { get; set; } = new List<string>();
        public void GetTask(string task) => Tasks.Add(task);

        public override string ToString() =>
           base.ToString()+":" + Tasks.Aggregate("",(tasks, task)=> tasks+"\n"+task);
           
    }
}
