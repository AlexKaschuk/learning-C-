using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GarbageCollector
{
    //class Program
    //{
    //    //static void Main(string[] args)
        //{
            //Console.WriteLine(GC.MaxGeneration);
            //string str1 = "Hello";
            //string str2;
            //Console.WriteLine(GC.GetGeneration(str1));
            //Console.WriteLine(GC.CollectionCount(0));
            //for (int i = 0; i < UInt16.MaxValue; i++) {
            //    str2 = i.ToString();
            //}
            //Console.WriteLine(GC.CollectionCount(0));
            //Console.WriteLine(GC.GetGeneration(str1));
            //GC.Collect(1);
            //Console.WriteLine(GC.GetGeneration(str1));
            //unsafe
            //{
                // int length = 10;
                //int* array = stackalloc int[length];
                //for (int i = 0; i < length; i++) {
                //    *(array + i) = int.Parse(Console.ReadLine());
                //}

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine($"{(int)(array + i)} {*(array+i)}");
                //}

                //string str = "hello world";
                //fixed (char* strPtr = str) {
                //    for (int i = 0; i < str.Length; i++)
                //    {
                //        *(strPtr + i) = char.ToUpper(strPtr[i]);
                //    }
                // } ;
                //Console.WriteLine(str);
                //int* arr = (int*)Marshal.AllocHGlobal(length*sizeof(int)).ToPointer();
                //GC.AddMemoryPressure(length * sizeof(int));
                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}
                //Marshal.FreeHGlobal((IntPtr)arr);
                //GC.RemoveMemoryPressure(length * sizeof(int));
                //using (IntArray a = new IntArray(20)) { 
                //}
            //}
        //}
    //}
}
