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
            Mathoperation mathOps = new Mathoperation();
            double[] numbers = new double[10];
            Console.WriteLine("Enter 10 numbers ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());

            }
            var resultt = Mathoperation.CalculatSandA(numbers);
            Console.WriteLine($"The sum of the numbers is {resultt.sum}.");
            Console.WriteLine($"The average of the numbers is {resultt.averagee}.");

            //Q2
            Console.Write("Input number of terms: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Cube cubee = new Cube(i);
                Console.WriteLine($"Number is : {i} is :{cubee.CalculateCube()}");
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

            DisplayPersonInfo(person);

        }
        public static void DisplayPersonInfo(Info person)
        {
            Console.WriteLine($"Name: {person.Name}\nAge: {person.Age}\nGender: {person.Gender}\nEmail: {person.Email}\nID: {person.ID}\nPhone: {person.Phone}");
        }
        public static int AgeInDays(int years)
        {
            DateTime currentDate = DateTime.Now;
            DateTime birthDate = currentDate.AddYears(-years);
            TimeSpan ageSpan = currentDate - birthDate;
            return ageSpan.Days;

        }
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



    }
}
