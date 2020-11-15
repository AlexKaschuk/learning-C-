using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class Magazine
    {
        private string magazineTitle;
        private Frequency period;
        private DateTime date;
        private int circulation;
        private Article[] articles;

        public Magazine(string title, Frequency fr, DateTime dateTime, int circul, params Article[] _articles) {
            magazineTitle = title;
            period = fr;
            date = dateTime;
            circulation = circul;
            articles = _articles;
        }

        public Magazine() : this("", 0, new DateTime(), 0, new Article()) { }

        public string MagazineTitle {
            get =>  magazineTitle;
            set => magazineTitle = value;
        }

        public Frequency Period {
            get => period;
            set => period = value;
        }

        public DateTime Date {
            get => date;
            set => date = value;        
        }

        public int Circulation {
            get => circulation;
            set => circulation = value;
        }

        public Article[] Articles {
            get => articles;
            set => articles = value;
        }

        public double AverageRait {
            get {
                double Aver = 0;
                foreach (Article a in Articles)
                    Aver += a.Rait;
                return Aver/ Articles.Length;
            }
        }

        public bool this[Frequency index]
        {
            get => Period == index; 
        }

        public void AddArticles(params Article[] arts) {
            Article[] temp = new Article[articles.Length + arts.Length];
            articles.CopyTo(temp, 0);
            int j = 0;
            for (int i = articles.Length; i < temp.Length; i++, j++)
                temp[i] = arts[j];
            articles = temp;
        }

        public override string ToString()
        {
            string tempStr = $"Magasine {MagazineTitle} date {Date} period {Period} circulation {circulation}\nArticles List: ";
            foreach (Article art in Articles) tempStr += $"{art.ToString()}\n";
            tempStr += $"Average articles rait {AverageRait}\n";
            return tempStr;
        }

        public string ToShortString() => $"Magasine {MagazineTitle}, date {Date.ToShortDateString()}, period {Period}, circulation {circulation}, Average articles rait {AverageRait} ";


    }
}
