using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
   public class Car
    {
        private string make;
        private int year;
        private string type;
        private decimal price;
        private string model;
        private string palletNo;
        private string color;
        private bool engineState;

        //Constuctor
        public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
        {

            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
            this.engineState = false;

        }

        //get & set
        public string Make
        {

            get { return make; }
            set { make = value; }
        }
        public int Year
        { get { return year; } set { year = value; } }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
        public decimal Price
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
        { get { return palletNo; } set { palletNo = value; } }
        public string Color
        { get { return color; } set { color = value; } }

        //Method start
        public void StartEngine()
        {

            if (!engineState)
            {
                engineState = true;
                Console.WriteLine("Engine started.");
            }
        }

        //Method stop
        public void StopEngine()
        {
            if (engineState)
            {
                engineState = false;
                Console.WriteLine("Engine stopped.");
            }
        }

        //Method Drive
        public void Drive()
        {
            if (engineState)
            {
                Console.WriteLine("The car is driving...");
            }
            else
            {
                Console.WriteLine("Start the engine first!");
            }
        }

        //Method
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
            Console.WriteLine($"Engine Running: {engineState}");


        }

    }
    public class BMW : Car
    {
        //Constructor
        public BMW(int year, decimal price, string model, string palletNo, string color) : base("BMW", year, "Sedan", price, model, palletNo, color)
        {

        } 

    }
}

