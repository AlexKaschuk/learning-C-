using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Button LoadButton = new Button();
            MenuItem LoadmenuItem = new MenuItem();
            DataManager Reciever = new DataManager { };
            ICommand LoadCommand = new LoadCommand { Manager = Reciever };
            TextBox text = new TextBox();
            text.Command = LoadmenuItem.Command = LoadButton.Command = LoadCommand;
              
            
            LoadButton.Press();

            Console.WriteLine(text.Text);
        }
    }
}
