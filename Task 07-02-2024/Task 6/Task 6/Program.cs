using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 2021, "Sedan", 30000, "Camry", "12345", "Blue");
            myCar.CarInfo();
            Console.WriteLine("****************************************");
            Car.DisplayTnfo("Honda", 2019);
            Console.WriteLine("****************************************");
            Car.DisplayInfo("BMW");
            Console.WriteLine("****************************************");
            myCar.Display();
            Console.WriteLine("****************************************");
            BMW myBMW = new BMW(2022, 50000, "Series 3", "67890", "Black");
            myBMW.Display();
            Console.WriteLine("****************************************");

        }
    }
}
