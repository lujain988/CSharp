using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_second_part
{
    public interface ISound
    {
        void MakeSound();
    }
    public abstract class Animal
    {
        //	A property string 
        public string Name { get; set; }
        //constructor 
        public Animal(string name) { Name = name; }
        //Methods
        public abstract void Eat();
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

    }
    //Class for dog and cat
    public class Dog : Animal, ISound
    {
        public Dog(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating dog food");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says : woooff!!");

        }
    }
    public class Cat : Animal, ISound
    {
        public Cat(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating cat food.");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}

