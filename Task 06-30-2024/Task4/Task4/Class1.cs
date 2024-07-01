using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task4
{
    

   
    //Q5
    public class Info
    {
        public int Age;
        public String Gender;
        public string Name;
        public string Email;
        public int ID;
        public string Phone;
        public Info()
        {
            Age = 18;
            Gender = "Not specified";
            Name = "Unknown";
            Email = "Unknown";
            ID = 0;
            Phone = "0770000000";
        }
        public bool SetAge(int age)
        {
            if (age >= 18 && age <= 60)
            {
                Age = age;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid age. Age must be between 18 and 60.");
                return false;
            }
        }
        public bool SetPhone(string phone)
        {
            if (phone.StartsWith("077") || phone.StartsWith("078") || phone.StartsWith("079"))
            {
                if (phone.Length == 10 && int.TryParse(phone, out _))
                {
                    Phone = phone;
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid phone number format. Phone number must be 10 digits.");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("Invalid phone number. Phone number must start with 077, 078, or 079.");
                return false;
            }
        }


        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }
}




