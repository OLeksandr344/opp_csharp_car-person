using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ 
    internal class Car
    {
        public string Name;
        public string Color;
        public double Price;
        public const string CompanyName = "MyCarCompany";

        public Car()
        {
            Name = "Default_Car";
            Color = "White";
            Price = 10000;
        }
        public Car(string name)
        {
            Name = name;
            Color = "White";
            Price = 10000;
        }
        public Car(string name, string color)
        {
            Name = name;         
            Color = color;
            Price = 10000;
        }

        public Car(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
        public void InputName(string name1)
        {
            Name = name1;
        }
        public void InputColor(string color1) 
        {          
            Color = color1;
        }
        public void InputPrice(double price1)
        {
            Price = price1;
        }
        public void PrintName() {Console.WriteLine($"Car Name: {Name}"); }
        public void PrintColor() { Console.WriteLine($"Car Color: {Color}"); }
        public void PrintPrice() { Console.WriteLine($"Car Price: {Price}"); }
        public void PrintCompany() { Console.WriteLine($"Car Price: {CompanyName}"); }

        public void PrintInfo()
        {
            Console.WriteLine($"Car Name: {Name}");
            Console.WriteLine($"Car Color: {Color}");
            Console.WriteLine($"Car Price: {Price}");
            Console.WriteLine($"Company Name: {CompanyName}");
        }
        public void ChangePrice(double x)
        {          
            double percent_change = x / 100;
            Price = Price * (1 + percent_change);                              
            Console.WriteLine($"Ціна автомобіля була змінена на {x}%.");
        }
    }

    internal class Person
    {
        private string Name;
        private DateTime BirthYear;
        
        public string GetName
        {
            get { return Name; }
        }
        public DateTime GetBirthYear
        {
            get { return BirthYear; }
        }
        public string SetName
        {           
            set { Name = value; }
        }
        public Person()
        {
            Name = "NoName";
            BirthYear = new DateTime(2000, 1, 1);
        }
        public Person(string name)
        {           
            Name = name;
            BirthYear = new DateTime(2000, 1, 1);
        }
        public Person(DateTime birth_date)
        {
            Name = "NoName";
            BirthYear = birth_date;
        }
        public Person(string name, DateTime birth_date)
        {
            Name = name;
            BirthYear = birth_date;
        }

        public int Age() 
        {
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - BirthYear.Year;
            return age;
        }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public  override string ToString()
        {
            string info = $"Іи'я - {Name}, дата народження - {BirthYear}, вік {Age()} ";
            return info;
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator == (Person person, Person other)
        {
            if (person.GetName == other.GetName) 
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Person person, Person other)
        {
            if (person.GetName != other.GetName)
            {
                return true;
            }
            return false;
        }
    }
    
}

