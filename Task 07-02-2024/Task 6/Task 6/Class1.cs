using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Car

    {
        //Fileds
        private string make;
        private int year;
        private string type;
        private int price;
        private string model;
        private string palletNo;
        private string color;

        //Constructor
        public Car(string make, int year, string type, int price, string model, string palletNo, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
        }

        //Get and Set
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string PalletNo
        {
            get { return palletNo; }
            set { palletNo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Methods
        public void CarInfo()
        {
            Console.WriteLine("Car Details; ");
            Console.WriteLine($"Make : {make}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Pallet No: {palletNo}");
            Console.WriteLine($"Color: {color}");
        }

        //display car information by make and year
        public static void DisplayTnfo(string make, int year)
        {
            Console.WriteLine($"Car Info: \nMake: {make}\nYear: {year}");
        }
        //Overload 
        public static void DisplayInfo(string make)
        {
            Console.WriteLine($"Car Info:\nMake: {make}");
        }

        // Method to print "Welcome Car"
        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }

    }
        //Class BMW
        public class BMW : Car
        {
            //Constructor
            public BMW(int year, int price, string model, string palletNo, string color)
      : base("BMW", year, "Sedan", price, model, palletNo, color)
            { }



            // Overriding method to print "Welcome BMW"
            public override void Display()
            {
                Console.WriteLine("Welcome BMW");
            }


        }
}
