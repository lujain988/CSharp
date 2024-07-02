using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_second_part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("SOSO");
            Cat myCat = new Cat("Mshmsh");
            myDog.Eat();
            myDog.Sleep();
            myDog.MakeSound();
            Console.WriteLine("****************************************");
            myCat.Eat();
            myCat.Sleep();
            myCat.MakeSound();
            Console.WriteLine("****************************************");

        }
    }
}
