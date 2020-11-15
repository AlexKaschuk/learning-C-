using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum CommodityType //тип товара
    {
        FrozenFood, Food, DomesticChemistry,
        BuildingMaterials, Petrol
    }
    enum TransportType //тип транспорта
    {
        Semitrailer, Coupling, Refrigerator, OpenSideTruck,
        FuelTruck
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от 1 до 5");
            int number = Int32.Parse(Console.ReadLine());
            if (number > 0 && number < 6)
            {
               CommodityType commodity = (CommodityType)
               Enum.GetValues(typeof(CommodityType)).GetValue(number - 1);
               TransportType transport = TransportType.Semitrailer;
                switch (commodity)
                {
                    case CommodityType.FrozenFood:
                        transport = TransportType.Refrigerator;
                        break;
                    case CommodityType.Food:
                        transport = TransportType.Semitrailer;
                        break;
                    case CommodityType.DomesticChemistry:
                        transport = TransportType.Coupling;
                        break;
                    case CommodityType.BuildingMaterials:
                        transport = TransportType.
                        OpenSideTruck;
                        break;
                    case CommodityType.Petrol:
                        transport = TransportType.FuelTruck;
                        break;
                }
                Console.WriteLine($"Для товара -{ commodity} необходим транспорт - { transport}.");
            }
            else
            {
                Console.WriteLine(typeof(CommodityType));
            }
        }
    }
}

