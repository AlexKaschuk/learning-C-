using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class Paper
    {
        public string Title { get; set; }
        public Person Autor { get; set; }
        public DateTime date { get; set; }

        public Paper(string Papertitle, Person PaperAutor, DateTime publicationDate) { Title = Papertitle; Autor = PaperAutor; date = publicationDate; }

        public Paper() : this("", new Person(), new DateTime(2000,01,01)) { }

        public override string ToString()=> $"Autor: {Autor.ToShortString()}, paper title: `{Title}`, publication date: {date.ToShortDateString()}\n";
        

    }
}
