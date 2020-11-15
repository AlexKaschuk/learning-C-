using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    public enum Style { rect, circular};
    public class Aplication
    {
        public Style Style { get; set; }
        public void ShowMsg(string msg) {

            Creator creator = null;
            switch (Style) {
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
