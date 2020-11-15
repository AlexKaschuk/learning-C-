using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPattern
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

        /// <remarks/>
        public int r030
        {
            get
            {
                return this.r030Field;
            }
            set
            {
                this.r030Field = value;
            }
        }

        /// <remarks/>
        public string txt
        {
            get
            {
                return this.txtField;
            }
            set
            {
                this.txtField = value;
            }
        }

        /// <remarks/>
        public decimal rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public string cc
        {
            get
            {
                return this.ccField;
            }
            set
            {
                this.ccField = value;
            }
        }

        /// <remarks/>
        public string exchangedate
        {
            get
            {
                return this.exchangedateField;
            }
            set
            {
                this.exchangedateField = value;
            }
        }
    }


}
