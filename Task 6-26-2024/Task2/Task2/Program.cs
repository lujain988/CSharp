using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] ints = new int[2];
            Console.WriteLine("First int: ");
            ints[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Second int: ");
            ints[1] = int.Parse(Console.ReadLine());
            int smaller = Math.Min(ints[0], ints[1]);
            Console.WriteLine($"The smaller intager is : {smaller}");

            //Q2
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int signValue = Math.Sign(num);
            string[] signs = { "-", "0", "+" };
            string sign = signs[signValue + 1];
            Console.WriteLine("The sign is " + sign);

            //Q3
            int[] intager = new int[3];
            Console.WriteLine("add num :");
            intager[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("add num :");
            intager[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("add num :");
            intager[2] = int.Parse(Console.ReadLine());
            Array.Sort(intager);
            Console.Write("The sorted numbers are :");
            Console.WriteLine($"{intager[0]} {intager[1]} {intager[2]} ");

            //Q4
            int[] value = new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            value[0] = int.Parse(Console.ReadLine());
            value[1] = int.Parse(Console.ReadLine());
            value[2] = int.Parse(Console.ReadLine());
            value[3] = int.Parse(Console.ReadLine());
            value[4] = int.Parse(Console.ReadLine());
            int maxValue = value.Max();
            Console.WriteLine("The maximum value is : " + maxValue);

            //Q5
            Console.WriteLine("Km/h: ");
            double kmPerHour = double.Parse(Console.ReadLine());
            double milePerHour = kmPerHour * 0.623171;
            Console.WriteLine($"{kmPerHour} km/h = {milePerHour} mile/h. ");

            //Q6
            Console.WriteLine("Add hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Add min: ");
            int minn = int.Parse(Console.ReadLine());
            int totalMin = (hours * 60) + minn;
            Console.WriteLine($"Total {totalMin} minutes. ");

            //Q7
            Console.WriteLine("Add minutes: ");
            int totalminutes = int.Parse(Console.ReadLine());
            int hour = totalminutes / 60;
            int minutes = totalminutes % 60;
            Console.WriteLine($"{totalminutes} minutes = to {hour} Hours, {minutes} Minutes");

            //Q8
            string[] sentences = new string[] {
            "Hello World!",
            "What are you doing here?",
            "Can you do more code so you can be better in this field!",
            "Hi my name is lujain",
            "You think you can be better, but guess what is waiting for you."
        };

            string st1 = sentences[0];
            string st2 = sentences[1];
            string st3 = sentences[2];
            string st4 = sentences[3];
            string st5 = sentences[4];

            Console.WriteLine(st1.Substring(0, 5));
            Console.WriteLine(st2.Substring(0, 5));
            Console.WriteLine(st3.Substring(0, 5));
            Console.WriteLine(st4.Substring(0, 5));
            Console.WriteLine(st5.Substring(0, 5));


        }

    }
    }
