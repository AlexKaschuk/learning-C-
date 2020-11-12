using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutes
{

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class currency
    {

        private int r030Field;
        private string txtField;
        private decimal rateField;
        private string ccField;
        private string exchangedateField;

        public int r030
        {
            get=>this.r030Field;
            set => this.r030Field = value;
        }

        public string txt
        {
            get => this.txtField;
            set => this.txtField = value;
        }

       
        public decimal rate
        {
            get => this.rateField;
            set => this.rateField = value;
        }

        public string cc
        {
            get => this.ccField;
            set => this.ccField = value;
        }

        public string exchangedate
        {
            get => this.exchangedateField;
            set => this.exchangedateField = value;
        }
    }

}
