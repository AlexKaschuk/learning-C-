using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{

    
    class Program
    {
        static void Main(string[] args)
        {



            Person my = new Person();
            my.Surname = "Kashchuk";
            my.Name = "Alex";
            my.Birthday = new DateTime(1982, 10, 12);



            {   //Person



                //Console.WriteLine(my.ToShortString());
                //string separators;
                //Console.WriteLine("enter separators");
                //separators=Console.ReadLine();
                //Console.WriteLine("enter array size");
                //string[] rowCol = Console.ReadLine().Split(separators.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                //int nrow = int.Parse(rowCol[0]), ncolumn = int.Parse(rowCol[1]);
                //Console.WriteLine($"{nrow} {ncolumn}");


                //Person[] persons1=new Person[nrow*ncolumn];
                //for (int i = 0; i < persons1.Length; ++i) persons1[i] = new Person();

                //Person[,] person2 = new Person[nrow, ncolumn];
                //for (int i = 0; i < person2.GetLength(0); ++i) {
                //    for (int j = 0; j < person2.GetLength(1); ++j)
                //    {
                //        person2[i, j] = new Person();
                //    }
                //}

                //Person[][] person3 = new Person[nrow][];
                //for (int i = 0; i < person3.Length; i++) {
                //    person3[i] = new Person[ncolumn];
                //    for (int j=0;j<ncolumn;j++) {
                //        person3[i][j] = new Person();
                //    } 
                //}

                //int counterTime = Environment.TickCount;

                //decimal averageAge=0;
                //foreach (Person item in persons1) averageAge += item.Age;
                //int counterTime2 = Environment.TickCount;
                //Console.WriteLine($"{counterTime2 - counterTime}");
                //Console.WriteLine(averageAge);



                //counterTime = Environment.TickCount;
                //averageAge = 0;
                //foreach (Person item in person2) averageAge += item.Age;


                //counterTime2 = Environment.TickCount;
                //Console.WriteLine($"{counterTime2 - counterTime}");
                //Console.WriteLine(averageAge);


                //counterTime = Environment.TickCount;
                //averageAge = 0;
                //for (int i = 0; i < person3.Length; i++)
                //{
                //    for (int j = 0; j < ncolumn; j++)
                //    {
                //        averageAge += person3[i][j].Age;
                //    }
                //}
                //counterTime2 = Environment.TickCount;
                //Console.WriteLine($"{counterTime2 - counterTime}");
                //Console.WriteLine(averageAge);

            }// Person


            { //Student
              //Student Iam = new Student();
              //Iam.PersonInfo = my;
              //Iam.Group = 911;
              //Iam.Education = Education.Master;
              //Iam.AddExams(new Exam("C++", 12, new DateTime(2020, 09, 12)));
              //Iam.AddExams(new Exam("C++", 10, new DateTime(2020, 09, 14)));
              //Iam.AddExams(new Exam("C++", 11, new DateTime(2020, 08, 12)), new Exam("C++", 11, new DateTime(2020, 08, 12)));

                ////Console.WriteLine(Iam.ToShortString());

                ////Console.WriteLine(Iam[Education.Master]);//true
                ////Console.WriteLine(Iam[Education.Bachelor]);//false
                ////Console.WriteLine(Iam[Education.SecondEducation]);//тут помилка, такого немає

                //Console.WriteLine(Iam.ToString());

                //Student[] StArr = new Student[750*750];
                //for (int i = 0; i < StArr.Length; i++)
                //    StArr[i] = Iam;

                //Student[,] StArr2 = new Student[750, 750];
                //for (int i = 0; i < StArr2.GetLength(0); i++)
                //    for (int j = 0; j < StArr2.GetLength(1); j++)
                //        StArr2[i, j] = Iam;

                //Student[][] StArr3 = new Student[750][];

                //for (int i = 0; i < StArr3.Length; i++)
                //{
                //    StArr3[i] = new Student[750];
                //    for (int j = 0; j < StArr3[i].Length; j++)
                //    {
                //        StArr3[i][j] = Iam;
                //    }
                //}

                //int counterTime5 = Environment.TickCount;
                //double averageGrade = 0;
                //foreach (Student n in StArr) averageGrade += n.Average;

                //int counterTime = Environment.TickCount;
                //Console.WriteLine($"{counterTime - counterTime5}");
                //Console.WriteLine(averageGrade / StArr.Length);




                //counterTime5 = Environment.TickCount;
                //averageGrade = 0;
                //foreach (Student n in StArr2) averageGrade += n.Average;

                //counterTime = Environment.TickCount;
                //Console.WriteLine($"{counterTime - counterTime5}");
                //Console.WriteLine(averageGrade / StArr2.Length);


                //counterTime5 = Environment.TickCount;
                //averageGrade = 0;
                //for (int i = 0; i < StArr3.Length; i++)
                //{
                //    for (int j = 0; j < StArr3[i].Length; j++)
                //    {
                //        averageGrade += StArr3[i][j].Average;
                //    }
                //}

                //counterTime = Environment.TickCount;
                //Console.WriteLine($"{counterTime - counterTime5}");
                //Console.WriteLine(averageGrade / StArr3.Length / 750);
            }//Student


            {//Articles


                //Magazine myMagasine = new Magazine("Play", Frequency.Monthly, new DateTime(2020, 01, 12), 10000, new Article(my, "C#", 100.0));
                //myMagasine.AddArticles(new Article(my, "C++", 100.0), new Article(my, ".Net", 100.0));

                //Console.WriteLine(myMagasine.ToShortString());
                //Console.WriteLine(myMagasine.ToString());
                //Console.WriteLine(myMagasine[Frequency.Monthly]);
                //Console.WriteLine(myMagasine[Frequency.Weekly]);
                //Console.WriteLine(myMagasine[Frequency.Yearly]);

                //Magazine[] magArr = new Magazine[750 * 750];
                //for (int i = 0; i < magArr.Length; i++)
                //    magArr[i] = myMagasine;

                //Magazine[,] magArr2 = new Magazine[750, 750];
                //for (int i = 0; i < magArr2.GetLength(0); i++)
                //    for (int j = 0; j < magArr2.GetLength(1); j++)
                //        magArr2[i, j] = myMagasine;

                //Magazine[][] magArr3 = new Magazine[750][];

                //for (int i = 0; i < magArr3.Length; i++)
                //{
                //    magArr3[i] = new Magazine[750];
                //    for (int j = 0; j < magArr3[i].Length; j++)
                //    {
                //        magArr3[i][j] = myMagasine;
                //    }
                //}

                //int counterTime5 = Environment.TickCount;
                //double averageGrade = 0;
                //foreach (Magazine n in magArr) averageGrade += n.AverageRait;

                //int counterTime = Environment.TickCount;
                //Console.WriteLine($"{counterTime - counterTime5}");
                //Console.WriteLine(averageGrade / magArr.Length);




                //counterTime5 = Environment.TickCount;
                //averageGrade = 0;
                //foreach (Magazine n in magArr2) averageGrade += n.AverageRait;

                //counterTime = Environment.TickCount;
                //Console.WriteLine($"{counterTime - counterTime5}");
                //Console.WriteLine(averageGrade / magArr2.Length);


                //counterTime5 = Environment.TickCount;
                //averageGrade = 0;
                //for (int i = 0; i < magArr3.Length; i++)
                //{
                //    for (int j = 0; j < magArr3[i].Length; j++)
                //    {
                //        averageGrade += magArr3[i][j].AverageRait;
                //    }
                //}

                //counterTime = Environment.TickCount;
                //Console.WriteLine($"{counterTime - counterTime5}");
                //Console.WriteLine(averageGrade / magArr3.Length / 750);
            }//Articles


            {//researchTeam
                ResearchTeam team = new ResearchTeam("Atmosphere", "National Geographic", 300, TimeFrame.TwoYears);

                Console.WriteLine(team.ToShortString());
                team.AddPapers(new Paper("Atmo", my, new DateTime(2020, 03, 02)), new Paper("Atmos", my, new DateTime(2020, 02, 02)));
                Console.WriteLine(team.ToString());

                Console.WriteLine(team[TimeFrame.Year]);
                Console.WriteLine(team[TimeFrame.TwoYears]);
                Console.WriteLine(team[TimeFrame.Long]);

                Console.WriteLine(team.Paper.ToString());




                ResearchTeam[] RTeam = new ResearchTeam[750 * 750];
                for (int i = 0; i < RTeam.Length; i++)
                    RTeam[i] = team;

                ResearchTeam[,] RTeam2 = new ResearchTeam[750, 750];
                for (int i = 0; i < RTeam2.GetLength(0); i++)
                    for (int j = 0; j < RTeam2.GetLength(1); j++)
                        RTeam2[i, j] = team;

                ResearchTeam[][] RTeam3 = new ResearchTeam[750][];

                for (int i = 0; i < RTeam3.Length; i++)
                {
                    RTeam3[i] = new ResearchTeam[750];
                    for (int j = 0; j < RTeam3[i].Length; j++)
                    {
                        RTeam3[i][j] = team;
                    }
                }

                int counterTime5 = Environment.TickCount;
                long  count = 0;
                foreach (ResearchTeam n in RTeam) count+=n.Id;

                int counterTime = Environment.TickCount;
                Console.WriteLine($"{counterTime - counterTime5}");
                Console.WriteLine(count / RTeam.Length);




                counterTime5 = Environment.TickCount;
                count = 0;
                foreach (ResearchTeam n in RTeam2) count += n.Id;

                counterTime = Environment.TickCount;
                Console.WriteLine($"{counterTime - counterTime5}");
                Console.WriteLine(count / RTeam2.Length);


                counterTime5 = Environment.TickCount;
                count = 0;
                for (int i = 0; i < RTeam3.Length; i++)
                {
                    for (int j = 0; j < RTeam3[i].Length; j++)
                    {
                        count += RTeam3[i][j].Id;
                    }
                }

                counterTime = Environment.TickCount;
                Console.WriteLine($"{counterTime - counterTime5}");
                Console.WriteLine(count / RTeam3.Length/750);










            }//researchTeam

        }

    }

}
