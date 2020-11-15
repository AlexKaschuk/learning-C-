using System;

namespace Command
{
    public class DataManager
    {
        public string Data { get; set; } 

        public void SaveData(string path) { Console.WriteLine($"data = {Data} save to {path}"); }
        public void LoadData(string path) { Data = "Hello world"; Console.WriteLine($"{Data} loaded from {path}"); }


    }
}