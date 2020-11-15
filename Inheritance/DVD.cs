using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DVD : Storage
    {
        public static double WriteReadSpeed { get; } = 7.8;//брав максимальну швидкість і будемо рахувати, що їх можна дозаписувати та перезаписувати
        public double MemoryValue { get; }

        public DVDType Type { get; }

        private double freeMemory;

        private double unilateralTypeMemory = 4700;
        private double twoSidedTypeMemory = 9000;

        public DVD(string name, string model, DVDType type) :base(name, model) 
        {
            Type = type;
            MemoryValue = Type == DVDType.unilateral ? unilateralTypeMemory : twoSidedTypeMemory;
            freeMemory = MemoryValue;
        }

        public override void CopyToDisc(double itemMemoryWeightInMB)
        {
            if (GetFreeMemory() > itemMemoryWeightInMB)
            {
                freeMemory = freeMemory - itemMemoryWeightInMB;
                //Console.WriteLine($"to copy the data need {itemMemoryWeightInMB / WriteReadSpeed} seconds, copied {itemMemoryWeightInMB} MB");
            }
            else
            {
                Console.WriteLine("not enough free memory");
            }
        }

        public override double GetFreeMemory() => freeMemory;


        public override double GetMemory() => MemoryValue;
        

        public override string StorageInfo() => $"DVD name: {base.StorageName} model: {base.StorageModel} memory: {MemoryValue}, free memory {freeMemory}; write/read speed: {WriteReadSpeed}MB/s";
    }
}
