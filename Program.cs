using ConsoleApp5;
using System;
using System.Collections.Generic;

internal class Program

    {
        static void Main(string[] args) 
    {
        Car myCar1 = new Car();
        Car myCar2 = new Car("BMW");
        Car myCar3 = new Car("AUDI","White", 20000);
        myCar1.ChangePrice(-10);
        myCar2.ChangePrice(-10);
        myCar3.ChangePrice(-10);

        myCar3.InputColor("Red");
        myCar3.PrintColor();
        myCar3.PrintInfo();
        Console.WriteLine("------------------");
        Person myPerson1 = new Person();
        Person myPerson2 = new Person("Olexandr", new DateTime(2004, 11, 18));
        Person myPerson3 = new Person("Taras", new DateTime(1976, 1, 1));
        Person myPerson4 = new Person("Anton", new DateTime(2014, 12, 19));
        Person myPerson5 = new Person("Mykhaylo", new DateTime(2012, 5, 30));
        Person myPerson6 = new Person("Sergiy", new DateTime(2002, 5, 18));      
        
        Console.WriteLine("------------------");
        Console.WriteLine($"{myPerson1.GetName} {myPerson1.Age()}");
        Console.WriteLine($"{myPerson2.GetName} {myPerson2.Age()}");
        Console.WriteLine($"{myPerson3.GetName} {myPerson3.Age()}");
        Console.WriteLine($"{myPerson4.GetName} {myPerson4.Age()}");
        Console.WriteLine($"{myPerson5.GetName} {myPerson5.Age()}");
        Console.WriteLine($"{myPerson6.GetName} {myPerson6.Age()}");
        List<Person> people = new List<Person> {myPerson1, myPerson2, myPerson3, myPerson4, myPerson5, myPerson6};      
        foreach (Person person in people)
        {
            if (person.Age() < 16)
            {
                person.SetName = "Very Young";
            }
        }
        myPerson1.Output();
        myPerson2.Output();
        myPerson3.Output();
        myPerson4.Output();
        myPerson5.Output();
        myPerson6.Output();
        Console.WriteLine("------------------");
        Dictionary<string, int> nameCount = new Dictionary<string, int>();

        foreach (Person person in people)
        {
            string name = person.GetName;
          
            if (nameCount.ContainsKey(name))
            {
                nameCount[name]++;
            }
            else
            {
                nameCount[name] = 1;
            }                    
        }       
        foreach (Person person in people)
        {
            foreach (var i in nameCount)
            {
                string name_key = i.Key;
                int count = i.Value;
                
                if (count > 1)
                {
                    if(name_key == person.GetName)
                    {
                        person.Output();
                    }
                }
            }
        }
           









    }
}
    
