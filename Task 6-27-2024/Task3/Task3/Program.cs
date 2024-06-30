using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //string[] ARR = { 1, 7, 9, 45 };
            //int arr2[] = { "Str", "alex", "moh" };
            //string arr3[] = { "the", "fox", "over", "lazy", "dog" };

            //Q2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };

            // "Banana"
            int indexBanana = Array.IndexOf(fruits, "Banana");
            Console.WriteLine(indexBanana);

            // "Tomato"
            int indexTomato = Array.IndexOf(fruits, "Tomato");
            Console.WriteLine(indexTomato);

            //Q3
            // Favorite Food
            string[] favoriteFood = { "pizza", "mansaf", "burger", "shawarma", "chips" };

            // Favorite Sport
            string[] favoriteSport = { "skating", "tennis", "football" };

            // Favorite Movie
            string[] favoriteMovie = { "Interstellar", "The Shawshank Redemption", "Lucy" };

           
            Console.WriteLine("Favorite Food:");
            foreach (string food in favoriteFood)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("\nFavorite Sport:");
            foreach (string sport in favoriteSport)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("\nFavorite Movie:");
            foreach (string movie in favoriteMovie)
            {
                Console.WriteLine(movie);
            }
            //Q4
            Console.Write("Input 3 numbers : ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int[] intNumbers = Array.ConvertAll(numbers, int.Parse);
            int sum = 0;
            foreach (int number in intNumbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum of three numbers: " + sum);

            //Q5
            Console.Write("Enter the number of odd terms you want to display: ");
            int n = int.Parse(Console.ReadLine());

            int summ = 0;
            int count = 0;

            Console.WriteLine("The odd numbers are:");

            for (int i = 1; count < n; i += 2)
            {
                if (i > 100) break;
                {
                    Console.WriteLine(i);
                    summ += i;
                    count++;
                }
            }

            Console.WriteLine("\nThe Sum of odd numbers is: " + summ);

            //Q6
            int rows = 20;
            int l = 1;

            while (l <= rows)
            {
                int j = rows - l;
                while (j > 0)
                {
                    Console.Write(" ");
                    j--;
                }

                int k = 1;
                while (k <= (2 * l - 1))
                {
                    Console.Write("*");
                    k++;
                }

                l++;
                Console.WriteLine();


            }
            //Q7
            int row = 4;
            int q = 1;
            int num = 1;

            while (q <= row)
            {
                int m = row - q;
                while (m > 0)
                {
                    Console.Write(" ");
                    m--;
                }

                int v = 1;
                while (v <= q)
                {
                    Console.Write(num + " ");
                    num++;
                    v++;
                }

                q++;
                Console.WriteLine();
            }
        }
    }
    }

