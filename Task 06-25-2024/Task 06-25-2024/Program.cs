using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_25_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] User;
            Console.WriteLine("Wrtie somthing:");
            String input = Console.ReadLine();
            Console.WriteLine("you enterd" +" "+ input);
            // Define variables
            double[] numbers = { 1.5, 2.4 };
           double sum = numbers.Sum();
            double difference = 0;
            if (numbers.Length >= 2)
            {
                difference = numbers[1] - numbers[0];
            }
            string myName = "Lujain alazzam";
            char firstLetter = 'L';
            bool firstDigit = false;
            int number = 8;
            const double piValue = 3.14;
            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(myName);
            Console.WriteLine(firstLetter);
            Console.WriteLine(firstDigit);
            Console.WriteLine(number);
            Console.WriteLine(piValue);
            // full name 
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");
            //Q3
            string[] cars = { "Honda", "Ford", "Toyota" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //Write a program in C # to store elements in an array and print it. 
            int[] arry = new int[10];
            Console.WriteLine("Input 10 elements in the arry:");
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write($"element - {i} : ");
                arry[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Elements are :");
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i]+ " ");
               
            }
            //Write a program in C# to find the sum of all elements of the array.
            int[] arry2 = new int[3];
            Console.WriteLine("");

          for (int i = 0;   i < arry2.Length; i++)
            {
                Console.Write("Value index:" + i + ":");
               arry2[i] = int.Parse(Console.ReadLine());
            }
               
            int summ = arry2.Sum();
           
                Console.WriteLine( "Sum is:"+summ+ " ");
            Console.ReadLine();
            


        }
    }
}
