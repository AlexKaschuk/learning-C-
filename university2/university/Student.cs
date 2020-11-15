using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university2
{
    public sealed class Student : Person, Iratable, IEnumerable, IDeepCloneable
    {
        public Education Education{ get; set; }
        public int Group { get; set; }


        public List<Exam> Exams { get; private set; } = new List<Exam>();

        // public Exam[] Exams { get; private set; } = new Exam[0];

        public Student(string fName, string lName, DateTime bday, Gender gen, Education education, int group, params Exam[]exams): base(fName, lName, bday, gen)
        {
            Education = education;
            Group = group;
            AddExam(exams);
        }

        public void AddExam(params Exam[] ex)
        {
            //Exam[] temp = new Exam[Exams.Length + ex.Length];
            //Array.Copy(Exams, temp, Exams.Length);
            //Array.Copy(ex, 0, temp, Exams.Length, ex.Length);
            //Exams = temp;

            //foreach (Exam e in ex)
            //    Exams.Add(e);
            Exams.AddRange(ex);
        }

        public override string ToString()
        {
            string str = $"{base.ToString()} \n";
            foreach (Exam e in Exams)
                str += e.ToString()+"\n";
            return str;
        }

        public override string ToShortString()=>
           $" {base.ToShortString()}; Education: {Education}; group {Group}; ";

       // public IEnumerator GetEnumerator()
        //{
        //    return Exams.GetEnumerator();
        //}

        public int CountExams {
            get => Exams.Count();
        }

        double Iratable.Rate { get => (double)Exams.Select(e => e.Mark).Average(); } 

        public Exam this[int idx]
        {
            get => Exams[idx];
            set => Exams[idx] = value;
        }

        public bool this[Education e] {
            get => e == this.Education;
        }

        // public decimal GetRate() =>(decimal)Exams.Select(e => e.Mark).Average();


        private class ExamsEnumerator : IEnumerator
        {
            int CurrentPosition = -1;
            Student s;
            public ExamsEnumerator(Student student) { s = student; }
            public object Current => s[CurrentPosition];
            public bool MoveNext()=> ++CurrentPosition < s.CountExams;
            public void Reset()=>CurrentPosition = -1;
            
        }

        public IEnumerator GetEnumerator()=> new ExamsEnumerator(this);

        public IEnumerable ReverseEnumerator() {
            for (int i = CountExams - 1; i >= 0; --i) {
                yield return Exams[i];
            }
         }

        public override object DeepClone() {
            Student studentClone = base.DeepClone() as Student;
            studentClone.Exams = new List<Exam>();
            studentClone.Exams.AddRange(Exams);
          // studentClone.Exams = this.Exams.Clone() as Exam[];
            return studentClone;// return new Student(...);

        }

        public void Sort() {
            Exams.Sort();
           // Array.Sort(Exams);
        
        }

        public void Sort(IComparer<Exam> comparer) {
            Exams.Sort(comparer);
         }




    }
}
