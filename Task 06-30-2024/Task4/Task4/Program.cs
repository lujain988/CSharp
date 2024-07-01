using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        //Q1
        {
            double[] numbers = new double[10];
            Console.WriteLine("Enter 10 numbers ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());

            }
            var resultt = CalculateSA(numbers);
            Console.WriteLine($"The sum of the numbers is {resultt.sum}.");
            Console.WriteLine($"The average of the numbers is {resultt.average}.");

            //Q2
            Console.Write("Input number of terms: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double cube = CalculateCube(i);
                Console.WriteLine($"Number {i} cubed is: {cube}");
            }

            //Q3
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] filteredYears = GetYear(years);
            Console.WriteLine("Years grater than 1950: ");
            foreach (int year in filteredYears)
            {
                Console.WriteLine(year);
            }

            //Q4
            Console.WriteLine("Enter year age in years: ");
            int ageInYears = int.Parse(Console.ReadLine());
            int ageInDays = AgeInDays(ageInYears);
            Console.WriteLine("Age in days: " + ageInDays);

            //Q5
            Info person = new Info();
            Console.WriteLine("Enter Age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                person.SetAge(age);
            }
            else
            {
                Console.WriteLine("Inalid age input. ");
                person.SetAge(18);
            }
            Console.WriteLine("Enter Gender: ");
            person.Gender = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("Enter ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                person.ID = id;
            }
            else
            {
                Console.WriteLine("Invalid. ");
                person.ID = 0;
            }
            Console.WriteLine("Write phone number: ");
            person.SetPhone(Console.ReadLine());
            Console.WriteLine("****************************************");


            person.DisplayPersonInfo();

        }
      
        //Q1
        public static (double sum, double average) CalculateSA(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = sum / numbers.Length;
            return (sum, average);
        }
        //Q2
        public static double CalculateCube(double number)
        {
            return number * number * number;
        }
        //Q3
        public static int[] GetYear(int[] years)
        {
            List<int> reuslt = new List<int>();
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    reuslt.Add(year);
                }
            }
            return reuslt.ToArray();
        }
        //Q4
        public static int AgeInDays(int years)
        {
            DateTime currentDate = DateTime.Now;
            DateTime birthDate = currentDate.AddYears(-years);
            TimeSpan ageSpan = currentDate - birthDate;
            return ageSpan.Days;

        }


    }
}
