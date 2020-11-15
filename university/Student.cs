using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class Student
    {

        private Person personInfo;
        private Education education;
        private int group;
        private Exam[] exams;

        public Student(Person person, Education _education, int groupNumber, params Exam[] _exams)
        {
            personInfo = person;
            education = _education;
            group = groupNumber;
            exams = _exams;
        }

        public Student() : this(new Person(), 0, 0, new Exam[0]) { }

        public Person PersonInfo {
            get { return personInfo; }
            set { personInfo = value; }
        }

        public Education Education {
            get { return education; }
            set { education = value; }
        }

        public int Group {
            get { return group; }
            set { group = value; }
        }


        public Exam[] Exams {
            get { return exams; }
            set { exams = value; }

        }
        public double Average {
            get {
                int summ = 0;
                foreach (Exam n in exams)
                    summ += n.ExamGrade;
                return exams.Length > 0 ? summ / exams.Length : 0;
            }
        }

        public bool this[Education index] {
            get { return Education==index; }
        }

        public void AddExams(params Exam[] examen) {
            Exam[] temp = new Exam[exams.Length + examen.Length];
            exams.CopyTo(temp,0);
            int j = 0;
            for (int i = exams.Length; i < temp.Length; i++, j++) {
                temp[i] = examen[j];
            }
            exams = temp;
        }

        public override string ToString()
        {
            string temp =  $" group {Group}\nstudent: {personInfo.ToString()} \neducation: {Education} \n";
            foreach (Exam n in exams) temp+=n.ToString();
            temp += $"Average grade: {Average}";
            return temp;
           
        }

        public virtual string ToShortString() =>    
             $"group {Group}\nstudent: {personInfo.ToString()} \neducation: {Education} \nAverage grade: {Average}";
           
        


    }
}
