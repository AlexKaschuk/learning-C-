using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class Article
    {
        public Person Autor { get; set; }
        public string ArticleTitle { get; set; }
        public double Rait { get; set; }

        public Article(Person ArticleAutor, string title, double raiting) {
            Autor = ArticleAutor;
            ArticleTitle = title;
            Rait = raiting;
        }

        public Article() : this(new Person(), "", 0) { }


        public override string ToString()
        {
            return $"Autor {Autor.ToShortString()}\nTopic Title: {ArticleTitle} Topic raiting {Rait} ";
        }



    }
}
