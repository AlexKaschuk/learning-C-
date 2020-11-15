using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Flash : Storage
    {
        public static int CopySpeed { get; } = 625;
        public double MemoryValue { get; }

        private double freeMemory;


        public Flash(string name, string model, double memoryValueInMB) : base(name, model)
        {
           MemoryValue = memoryValueInMB;
           freeMemory = MemoryValue;
        }

        public override void CopyToDisc(double itemMemoryWeightInMB)
        {
            if (GetFreeMemory() >= itemMemoryWeightInMB)
            {
                freeMemory = freeMemory - itemMemoryWeightInMB;
                //Console.WriteLine($"to copy the data need {itemMemoryWeightInMB / CopySpeed} seconds, copied {itemMemoryWeightInMB} MB");
            }
            else {
                Console.WriteLine("not enough free memory");
            }
        }

        public override double GetFreeMemory()=> freeMemory;
        public override double GetMemory()=> MemoryValue;
        public override string StorageInfo()=> $"Flash name: {StorageName} model: {StorageModel} memory: {MemoryValue}, free memory {GetFreeMemory()} copy speed: {CopySpeed}MB/s";
       
    }
}
