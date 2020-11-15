using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace university2
{

    
    class Program
    {
        static void Main(string[] args)
        {

            //1
            Student[] st = { new Student("Alex", "Kaschuk", new DateTime(1982, 10, 12), Gender.Male, Education.Master, 911, new Exam("C#", 12, new DateTime(2020, 01, 20))) };
            //Student[] stClone = st.Clone() as Student[];
            //st[0].Name = "Bob";

            Student s = new Student("Alex", "Kaschuk", new DateTime(1982, 10, 12), Gender.Male, Education.Master, 911, new Exam("C#", 12, new DateTime(2020, 01, 20)));
            Student s1 = new Student("Alex", "Kaschuk", new DateTime(1982, 10, 12), Gender.Male, Education.Barchelor, 911, new Exam("C#", 9, new DateTime(2020, 01, 20)));
            Student s2 = new Student("Alex", "Kaschuk", new DateTime(1982, 10, 12), Gender.Male, Education.Barchelor, 911, new Exam("C#", 9, new DateTime(2020, 01, 20)));
            //Student SClone = s.DeepClone() as Student;
            s.Name = "Bob";
            //s[0] = new Exam("C++", 12, new DateTime(2020, 01, 20));
            s.AddExam(new Exam("C++", 11, new DateTime(2020, 01, 2)), new Exam("C", 12, new DateTime(2020, 01, 21)), new Exam("C++", 10, new DateTime(2020, 01, 20)), new Exam("C#", 12, new DateTime(2020, 01, 20)), new Exam("C", 9, new DateTime(2020, 01, 20)));
            s1.AddExam(new Exam("C++", 11, new DateTime(2020, 01, 2)), new Exam("C", 12, new DateTime(2020, 01, 21)), new Exam("C++", 10, new DateTime(2020, 01, 20)), new Exam("C#", 12, new DateTime(2020, 01, 20)), new Exam("C", 9, new DateTime(2020, 01, 20)));
            //s.Sort();
            //WriteLine(s.ToString());

            //WriteLine(s.ToShortString());
            //foreach (Exam e in s) 
            //    if (e.Mark > 9) WriteLine(e.ToString());



            //2

            //s.Sort(new Exam());
            //foreach (Exam item in s)
            //    WriteLine(item);

            //WriteLine();
            //s.Sort(new ExamComparerByDate());
            //foreach (Exam item in s)
            //    WriteLine(item);
            
            //WriteLine();
            //s.Sort();
            //foreach (Exam item in s)
            //    WriteLine(item);


            StudentCollection<string> StudCollection = new StudentCollection<string>();
            StudCollection.AddStudent(s.Id, s);
            StudCollection.AddStudent(s1.Id, s1);
            StudCollection.AddStudent(s2.Id, s2);

            //foreach (KeyValuePair<string, Student> item in StudCollection)
            //    WriteLine(item);

            //WriteLine((s1 as Iratable).Rate);
            //WriteLine(StudCollection.MaxAverageMark);

            //foreach (KeyValuePair<string, Student> item in StudCollection.EducationForm(Education.Barchelor))
            //    WriteLine(item);

           

            StudentCollection<Person>CollectionPerson = new StudentCollection<Person>();//class Person is abstract нові обєкти персон не створюються, додати не можливо, єдиний вихід приводити студента до Персона, якби не був абстрактним додавалось би конструкцією AddStudent(new Person(s.Name, s.Surname, s.Birthday, s.Gender),s)

            CollectionPerson.AddStudent(new Person(s.Name, s.Surname, s.Birthday, s.Gender), s);
            CollectionPerson.AddStudent(new Person(s1.Name, s1.Surname, s1.Birthday, s1.Gender), s1);
            CollectionPerson.AddStudent(new Person(s2.Name, s2.Surname, s2.Birthday, s2.Gender), s);

            foreach (KeyValuePair<Person, Student> item in CollectionPerson)
                WriteLine(item);






        }

    }

    




}
