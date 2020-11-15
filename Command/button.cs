using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class Control
    {
        ICommand command;

        public void Press() => OnClick();
        
        public event Action Click;

        protected void OnClick() => Click?.Invoke();
        
        public ICommand Command { get=>command; set { command = value; Click += command.Execute; } }

        public abstract void Render();

}

    public class Button: Control
    {
        public override void Render()=>Console.WriteLine("BUTTON");

    }

    public class MenuItem : Control
    {
        public override void Render() => Console.WriteLine("MENUITEM");
    }


    public class TextBox : Control
    {
        public override void Render() => Console.WriteLine("TEXTBOX");

        public string Text { get; set; }

    }
}
