using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    [Serializable]
    public class CinemaHall
    {
        public string[,] seats;

        int rows = 10;

        int seat = 12;

        public List<double> prices = new List<double>() {15,12,10}; 

        public CinemaHall() {
            seats = new string[rows, seat];
            for (int i = 0; i < seats.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < seats.Length / (seats.GetUpperBound(0)+1); j++) {
                    seats[i, j] = (j + 1).ToString();
                }
            }
         }

        public void ShowSeats() {
            for (int i = 0; i < 20; i++)
               Console.Write("-");
            Console.Write("MONITOR");
            for (int i = 0; i < 20; i++)
                 Console.Write("-");
            Console.WriteLine();
            for (int i = 0; i < seats.GetUpperBound(0) + 1; i++)
            {
                Console.Write($"{i + 1,2} row: ");
                for (int j = 0; j < seats.Length/ (seats.GetUpperBound(0)+1); j++)
                    Console.Write($"[{seats[i, j]}]");
                Console.WriteLine();
            }
        }

        public bool BlockSits(int row, int number)
        {
            if (seats[row - 1, number - 1] != "x")
            {
                seats[row - 1, number - 1] = "x";
                return true;
            }
            else 
                Console.WriteLine("This seat is blocked");
            return false;
        }


        public double GetPrice(int row, double koef) {
            if (row >= 1 && row <= 4) return prices[1] * koef;
            else if (row > 4 && row <= 9) return prices[0] * koef;
            else return prices[2] * koef;
        }

        public void ShowPrice(double koef)=>
            Console.WriteLine($"ряди 1-4 вартість {prices[1] * koef}, ряди 5-9 вартість {prices[0] * koef}, ряди 10-12 вартість {prices[2] * koef}");
 
        public string GetBlockedSeats() {
            string tmp = "";
            for (int i = 0; i < seats.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < seats.Length / (seats.GetUpperBound(0) + 1); j++)
                    if (seats[i, j] == "x") { tmp += $"{i + 1},{j + 1},"; }
            }
            tmp.Trim('\n', ' ');
            return tmp;
        }

        public override string ToString() => $"Cinemahall total number of seats: {rows*seat}, row {rows}, seats in row {seat}";
        

    }
}
