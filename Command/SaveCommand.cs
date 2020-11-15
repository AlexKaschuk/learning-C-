using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SaveCommand : ICommand
    {
        public DataManager Manager { get; set; }

        public void Execute() => Manager.SaveData("temp.bin");
    }    
    
    
    
    public class LoadCommand : ICommand
    {
        public DataManager Manager { get; set; }

        public void Execute() => Manager.LoadData("temp.bin");
    }
}
