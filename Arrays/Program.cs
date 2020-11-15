using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //дз с урока 2 PDF

            //1
            //int[] myArr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1 };
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    myArr[i] = myArr[i] == 0 ? -1 : myArr[i];//якщо додати -1-i для другої задачі краще видно сортування від няйменшого до найбільшого в другій задачі
            //}
            //printArr(myArr);
            ////2

            //Array.Sort(myArr);
            //printArr(myArr);

            ////3
            //int num, counter = 0;
            //Console.WriteLine("введите число для поиска в массиве");
            //num = Convert.ToInt32(Console.ReadLine());
            //foreach (int item in myArr)
            //{
            //    counter += item == num ? 1 : 0;
            //}
            //Console.WriteLine($"число {num} знаходиться у масиві {counter} раз");

            //4

            //int[,] seconrArr = new int[,] { { 0, 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 0, 0, 0, 0} };//2 варіанти - поміняти порядок виводу або створити новий масив, у який копіювати у іншому опрядку і переприсвоїти його, методи Array лише для одномірних масивів, помилку видає
            //changeArr(ref seconrArr);
            //printArr(seconrArr);




            //DZ
            int[] myArrDz = new int[] { -1, 0, 0,-3, 0, 6, 7, 8, 9, -5, 0, 0, 0,-4, 0, 0, 4, 4, 5, 4, -3, -2 };


            //1,2
            //int counter = 1;//3
            //var quantity = myArrDz.GroupBy(x => x).Where(x => x.Count() > counter).Count();
            //Console.WriteLine(quantity);
            //printArr(myArrDz);

            //3
            //int min = Array.IndexOf(myArrDz, myArrDz.Min()), 
            //    max = Array.IndexOf(myArrDz, myArrDz.Max()), 
            //    elem = min>max?min-max-1:max-min-1;
            //int[] myArr2Dz = new int[elem];
            //if (max-min > 0)
            //    Array.Copy(myArrDz, min+1, myArr2Dz, 0, elem);
            //else 
            //    Array.Copy(myArrDz, max+1, myArr2Dz, 0, elem);
            //printArr(myArr2Dz);


            //4
            //Console.WriteLine($"в масиві {uniqueNum(myArrDz)} унікальних чисел, які входять по 1 разу");

            //5
            //int[] myArr3Dz = { 0, 0, 0, 0, 0, 0, 3, 3, 3, 5, 5, 5, 0, 0, 0, 0,0,0,0,0,0,0 };
            //Console.WriteLine($"найбільше підряд нулів у масиві - {ZeroNum(myArr3Dz)}");

            //6
            //Array.Sort(myArrDz); // перший метод
            //Array.Reverse(myArrDz);
            //Array.Sort<int>(myArrDz, new Comparison<int>(
            //        (i1, i2) => i2.CompareTo(i1)));//другий метод
            //printArr(myArrDz);


            //7
            //int[] myArr4Dz = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 5, -4, 4, 15, -15, 5, 4, 3, 2 };
            //Array.Sort<int>(myArr4Dz, new Comparison<int>(
            //     (i1, i2) => (i1 % 2==0|| i1 % 2 == -0).CompareTo(i2 % 2==0 || i2 % 2 == -0)));
            //printArr(myArr4Dz);

            //8
            //removeNext(ref myArrDz, Array.IndexOf(myArrDz, myArrDz.Max()));
            //printArr(myArrDz);


            //9
            //removeNext(ref myArrDz, Array.IndexOf(myArrDz, myArrDz.Max()), Array.IndexOf(myArrDz, myArrDz.Min()),0);//пробував робити все через методи масивів, щось не дуже розібрався
            //printArr(myArrDz);

            //10
            //removePrevious(ref myArrDz, Array.IndexOf(myArrDz, myArrDz.Max()));
            //printArr(myArrDz);

            //11
            //int[] myArrDz5 = new int[] { 0, 1, 2, 3, -4, -5, -6, 7, 8, 9, 0, 5, -4, -4, -15, -15, 5, 4, 3, 2 };
            //Console.WriteLine($"найбільше підряд відємних чисел у масиві - {NegativeNum(myArrDz5)}"); 

            //12
            //int res = Array.LastIndexOf(myArrDz, myArrDz.Last(x => x > 0)) - Array.IndexOf(myArrDz, myArrDz.First(x => x > 0))-2;//-2 це не включаючи межі
            //Console.WriteLine(res);

            //13
            //int[] myArrDz6 = new int[] { 0, 1, 2, 3, -4, -5, -6, 7, 0, 8, 9,  5, -4, -4, -15, -15, 5, 4, 3, 2, 0 };
            //Console.WriteLine($"найбільше підряд додатніх чисел між нулями у масиві{PositiveNumBetweenZero(myArrDz6)}" ); 

            //14
            //Console.WriteLine($"найбільша сума додатніх чисел у проміжку між відємними = {sumPositive(myArrDz)}");

            //15
            //Console.WriteLine($"кількість груп чисел, що містять нулі  = {sumZeroGroups(myArrDz)}");



            //strings DZ
            //1
            //string MyStr = "Lorem ipsum 3dolor sit Amet, 1consectetur adipiscing 2elit";
            //stringStatistic(MyStr);

            //2
            //changeStr();

            //3

            //string MyStr1 = "Lorem ipsum 3dolor sit Amet, 1consectetur adipiscing 2elit";
            //Console.WriteLine(findSubstr(MyStr1)?"вказаний відрізок наявний у стрічці": "вказаний відрізок відсутній у стрічці");

            //4
            //string MyStr2 = "Lorem ipsum 3dolor sit Amet, 1consectetur adipiscing 2elit";
            //changeStr(ref MyStr2);
            //Console.WriteLine(MyStr2);

            //5
            //string[] strArr = {
            //    "Lorem ipsum dolor",
            //    "sit Amet",
            //    "consectetur adipiscing elit"
            //};

            //addStrInArr(ref strArr, "mama");
            //foreach (string item in strArr) Console.WriteLine(item);
            //delStrInArr(ref strArr, "mama");
            //foreach (string item in strArr) Console.WriteLine(item);


            //6
            //string MyStr3 = "Lorem( )ipsum3dolor( (sit Amet, 1consectetur( adipiscing 2elit";//самий простий спосіб, можливо було б краще перевіряти чи після кожної відкриваючої є закриваюча
            //Console.WriteLine(brackets(MyStr3) ? "true" : "false");


            //7
            //var str = "(4+7)/2-(2-8)*3";
            //var result = new DataTable().Compute(str, null);
            //Console.WriteLine(result);


            //8
            //int num = 1998;
            //string z = num.ToString();
            //Console.WriteLine(z);

            //9

            //string numer0 = "33,95";
            //var res11 = numer0.Where(x => char.IsPunctuation(x)).Count() > 0 ? Convert.ToDouble(numer0) : Convert.ToInt32(numer0);//формат з комою, якщо треба міняти налаштування вводу 
            //Console.WriteLine(res11);

            //10

            //string str2 = "А роза упала на лапу Азора".Replace(" ", "").ToUpper();
            //Console.WriteLine(str2.SequenceEqual(str2.Reverse()));

            //11
            //string str1 = "Lorem ipsum 3dolor sit Amet, Lorem ipsum 3dolor sit Amet,Lorem ipsum 3dolor sit Amet";
            //string findStr="Lorem";
            //Console.WriteLine(countSubstr(str1, findStr));
        }


        static void printArr(int[] arr) {
            foreach (int item in arr) {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
        }
        static void printArr(int[,] arr)
        {
           for (int i = 0; i < arr.Rank; i++)
            {
                for (int j = 0; j < arr.Length / arr.Rank; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
        static void changeArr(ref int[,] arr) {
            int[,] tempArr = new int[arr.Rank, arr.Length / arr.Rank];
            for (int i = arr.Rank-1, z = 0 ; i >= 0; i--, z++)
            {
                for (int j = 0; j < arr.Length / arr.Rank; j++)
                {
                    tempArr[z, j] = arr[i, j];
                }
            }
            arr = tempArr;
        }


       



        //DZ

        static int uniqueNum(int[] arr) {
            int counter = 0;
            bool flag = true;
            for (int i = 0; i < arr.Length; i++) {
                if (flag == false) counter++;
                flag = false;
                for (int j = 0; j < arr.Length; j++) {
                     if (arr[j] == arr[i] && j!=i) {
                        flag = true;
                    }
                }
            }
            return counter;
         }
        static int ZeroNum(int[] arr) {
            int counter = 0, zero=0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == 0)
                {
                   counter++;
                   if (counter > zero) zero = counter;
                }
                else counter = 0;
            }
            return zero;
        }
        static int NegativeNum(int[] arr)
        {
            int counter = 0, negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    counter++;
                    if (counter > negative) negative = counter;
                }
                else counter = 0;
            }
            return negative;
        }
        static int PositiveNumBetweenZero(int[] arr)
        {
            int counter = 0, positive = 0;
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 && i != arr.Length - 1)
                {
                    while (arr[i+1]!=0) { i++; counter=arr[i]>0?counter+1:counter;};
                    if (counter > positive) { positive = counter; counter = 0; };
                }
            }
            return positive;
        }
        static void removeNext(ref int[] arr, int position) {
            int[] temp = new int[arr.Length - 1];
            bool deleted = false;
            int maxPos = position;
            for (int i = 0; i < arr.Length-1; i++) {
                if (i <= maxPos) temp[i] = arr[i];
                else if (arr[i] > 0 && deleted == false) { temp[i] = arr[i + 1]; deleted = true; }
                else if (deleted == true) temp[i] = arr[i + 1];
                else temp[i] = arr[i];
            }
            arr = temp;
        }
        static void removeNext(ref int[] arr, int StartPosition, int EndPosition,int deleted_number) {
            int min = StartPosition > EndPosition? EndPosition: StartPosition,
                max = EndPosition < StartPosition ?  StartPosition: EndPosition, 
                counter = 0, plus=0;
            for (int i = min; i < max; i++) {
                if (arr[i] == deleted_number) counter++;
            }
            int[] temp = new int[arr.Length - counter];
            for (int i = 0; i < temp.Length; i++)
            {
                if (arr[i + plus] == deleted_number && i > min && i < max) 
                    while (arr[i + plus] == deleted_number) plus++; 
                             
                temp[i] = arr[i + plus];
            }
            arr = temp;
        }
        static void removePrevious(ref int[] arr, int position)
        {
            int[] temp = new int[arr.Length - 1];
            bool deleted = false;
            int maxPos = position;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
               if (i >= maxPos-1) { temp[i] = arr[i + 1]; }
               else if (arr[i] > 0 && deleted == false) { temp[i] = arr[i+1]; deleted = true; }
               else temp[i] = arr[i];
            }
            arr = temp;
        }
        static int sumPositive(int[] arr)
        {
            int sum = 0, tempSum=0;
            for (int i = 0; i < arr.Length-1; i++) {
               
                if (arr[i] < 0 && arr[i + 1] >= 0) {
                    Console.WriteLine(i);
                    while (arr[++i]>=0) tempSum += arr[i];  
                    sum = sum > tempSum ? sum : tempSum;
                    tempSum = 0;--i;
                }
            }
            return sum;
        }
        static int sumZeroGroups(int[] arr)
        {
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] < 0 && arr[i + 1] >= 0)
                {
                    while (arr[++i] >= 0) if(arr[i]==0) flag=true;
                    sum += flag == true ? 1 : 0;
                    flag = false;
                    i--;
                }
            }
            return sum;
        }

        //stringsMetods


        static void stringStatistic(string anyStr) {
            string tempStr = anyStr;
            Console.WriteLine($"символов = {anyStr.Length}\n" +
                $"пробелов {anyStr.Length - tempStr.Replace(" ", "").Length}\n"+
                $"запятых {anyStr.Length - tempStr.Replace(",", "").Length}\n"+
                $"Прописных букв: { anyStr.Count(Char.IsUpper)}\n"+
                $"Строчных  букв: { anyStr.Count(Char.IsLower)}\n"+
                $"цифр: {anyStr.Where((n) => n >= '0' && n <= '9').Count()}");
        }
        static void changeStr() {
            Console.WriteLine("Введіть строку:");
            string temp=Console.ReadLine();
            Console.WriteLine("Введіть символ, який треба змінити:");
            char symb = (char)Console.Read();
            string s = temp.Replace(symb, char.ToUpper(symb)).Remove(temp.LastIndexOf(symb)+1, temp.Length - temp.LastIndexOf(symb)-1);
            Console.WriteLine(s);
        }
        static void changeStr(ref string anyStr)
        {
            Console.WriteLine("Введіть фразу, який треба змінити:");
            string temp = Console.ReadLine();
            Console.WriteLine("Введіть фразу, на яку треба змінити:");
            string temp2 = Console.ReadLine();
            string s =  anyStr.Replace(temp, temp2);
            anyStr = s;


        }
        static bool findSubstr(string anyStr) {
            Console.WriteLine("введіть шуканий відрізок стрічки");
            string temp = Console.ReadLine();
            return anyStr.Contains(temp);
        
        }
        static void addStrInArr(ref string[]arr,string str) {
            string[] tempArr = new string[arr.Length+1];
            arr.CopyTo(tempArr,0);
            tempArr[arr.Length] = str;
            arr = tempArr;
        }
        static void delStrInArr(ref string[] arr, string str) {
            string[]temp=arr.Where(x => x != str).ToArray();
            arr = temp;
        }
        static bool brackets(string anyStr) {
            int t1 = anyStr.Where(x => x == ')').Count();
            int t2 = anyStr.Where(x => x == '(').Count();
            return t1==t2;
         }
        static int countSubstr(string anyStr, string substring) {
            int count = (anyStr.Length - anyStr.Replace(substring, "").Length) / substring.Length;
            return count;
        }

     














    }
}

