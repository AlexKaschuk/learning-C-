using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class HDD : Storage
    {
        public static int CopySpeed { get; } = 60;

        public double MemoryValue { get; }

        public int SectionsQuantity { get; private set; } = 1;

        private double[] sections = new double[1];
        private double freeMemory;

        public string SectionsVolume()
        {
            string tmp = "";
            char i = 'C';
            foreach (double item in sections)
            {
                tmp += $"disc {i} volume {item}\n";
                i++;
            }
            return tmp;
        }
        public HDD(string name, string model, double memoryInMB) :base(name, model) 
        {
            MemoryValue = memoryInMB;
            freeMemory = memoryInMB;
            sections[0] = memoryInMB;
        }

        public void resizeHDDSections(int NewSectionQuantity, params double[] sectionsVolumeValue)
        {

            if (NewSectionQuantity == sectionsVolumeValue.Length && sectionsVolumeValue.Sum() == MemoryValue)
            {
                SectionsQuantity = NewSectionQuantity;
                double[] TmpSections = new double[SectionsQuantity];
                for (int i = 0; i < TmpSections.Length; ++i)
                    TmpSections[i] = sectionsVolumeValue[i];
                sections = TmpSections;
            }
            else if (NewSectionQuantity == sectionsVolumeValue.Length && sectionsVolumeValue.Sum() < MemoryValue)
            {

                SectionsQuantity = NewSectionQuantity+1;
                double[] TmpSections = new double[SectionsQuantity];
                for (int i = 0; i < TmpSections.Length - 1; ++i)
                    TmpSections[i] = sectionsVolumeValue[i];
                TmpSections[NewSectionQuantity] = MemoryValue - sectionsVolumeValue.Sum();
                sections = TmpSections;
            }
            else
            {
                Console.WriteLine("wrong resize params");
            }
        }

        public override void CopyToDisc(double itemMemoryWeightInMB)
        {

            if (GetFreeMemory() > itemMemoryWeightInMB && SectionsQuantity == 1)
            {
                freeMemory = freeMemory - itemMemoryWeightInMB;
                //Console.WriteLine($"to copy the data need {itemMemoryWeightInMB / CopySpeed} seconds, copied {itemMemoryWeightInMB} MB");
            }
            else if ( SectionsQuantity > 1) 
            {
                for (int i = 0; i < sections.Length;++i) {
                    if(sections[i] < itemMemoryWeightInMB && i == sections.Length-1) Console.WriteLine("not enough free memory on section");
                    if (itemMemoryWeightInMB == 0) break;
                    if (sections[i] < itemMemoryWeightInMB) continue;
                    if (sections[i] >= itemMemoryWeightInMB) {
                        //Console.WriteLine($"to copy the data need {itemMemoryWeightInMB / CopySpeed} seconds, copied {itemMemoryWeightInMB} MB");
                        sections[i] -= itemMemoryWeightInMB;
                        itemMemoryWeightInMB = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("not enough free memory");
            }
        }

        public override double GetFreeMemory() => freeMemory;
        public override double GetMemory() => MemoryValue;
        public override string StorageInfo() => $"HDD name: {base.StorageName}, model: {base.StorageModel}, memory: {MemoryValue}, free memory {GetFreeMemory()} copy speed: {CopySpeed}MB/s";
    }
}
