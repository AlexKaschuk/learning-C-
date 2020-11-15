using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public enum Style { rect, circular };
    public class Aplication
    {

        static Aplication unique;
        public Style Style { get; set; }

        protected Aplication(Style s) { }

        public static Aplication Instance() {
            if (unique == null)
                unique = new Aplication(Style.rect);
            return unique;
        }
           
       

        public void ShowMsg(string msg)
        {
            Creator creator = null;
            switch (Style)
            {
                case Style.rect:
                    creator = new RectCreator();
                    break;
                case Style.circular:
                    creator = new CircleCreator();
                    break;
            }
            creator.Show(msg);
        }
    }
}
