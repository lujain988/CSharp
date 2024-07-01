using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1

            Car myCar = new Car("Toyota", 2021, "Sedan", 30000m, "Camry", "12345", "Blue");
            myCar.CarInfo();
            Console.WriteLine("****************************************");
            myCar.StartEngine();
            myCar.Drive();
            //myCar.StopEngine();
            Console.WriteLine("****************************************");
            myCar.CarInfo();
            Console.WriteLine("****************************************");
            BMW myBMW = new BMW(2022, 5000, "Series 3", "67890", "Black");
            myBMW.StartEngine();
            myBMW.Drive();
            myBMW.StopEngine();
            Console.WriteLine("****************************************");
            myBMW.CarInfo();
            Console.WriteLine("****************************************");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
