using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPattern
{
    public enum Genre { Programing, Design };


    [UpperCase(true)]
    [Serializable]

    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public decimal Price { get; set; }

        public Genre Genre { get; set; }

        public override string ToString() => $"{Id}\t{Name}\t{Autor}\t{Price:F2}\t{Genre}";

    }
}
