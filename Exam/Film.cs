using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam
{
    [Serializable]
    public class Film
    {

        public string Name { get; set; }

        public string Genre { get; set; }

        public int Length { get; set; }

        public int AgeLimit { get; set; }

        public Film(string name, string genre, int agelimit, int length) { Name = name; Genre = genre; AgeLimit = agelimit; Length = length; }

         public override string ToString() => $"'{Name}', genre '{Genre}', length: {Length},  ageLimit {AgeLimit}";

    }
}
