using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    unsafe
    public class IntArray : IDisposable
    {
        int* pointer = null;

        bool isDisposed = false;
        public int Length { get; private set; }
        public IntArray(int length = UInt16.MaxValue) {
            Length = length;
            pointer = (int*)Marshal.AllocHGlobal(Length * sizeof(int)).ToPointer();
            GC.AddMemoryPressure(Length * sizeof(int));
            for (int i = 0; i < Length; i++)
            {
                *(pointer + i) = 0;
            }
        }

        ~IntArray() {
            clean(false);
            Console.WriteLine("finallize");
        }
        
        protected void clean(bool dDispose) // true - user, false - GC
        {
            if (!isDisposed) {
                //if (dDispose) {
                   //вивільняються тільки керовані ресурси стріми тощо
                //}
                Marshal.FreeHGlobal((IntPtr)pointer);
                GC.RemoveMemoryPressure(Length * sizeof(int));
                pointer = null;
                isDisposed = true;
            }
        
        }

        public void Dispose()
        {
            clean(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("finallize d");
        }

        public int this[int idx] { get => pointer[idx];set => pointer[idx] = value;}
        
    }
}
