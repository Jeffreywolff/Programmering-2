using System;
using System.Collections.Generic;

namespace HelloWorld0
{

    class Person
    {
        public string Age { get; set;}

        public string Name { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<string>();
            var nameArr = new string[5];
            

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter age:  ");
                var person = new Person();
                person.Age = Console.ReadLine();
                personList.Add(person.Age);
                Console.WriteLine("Enter name:  ");
                person.Name = Console.ReadLine();
                personList.Add(person.Name);
            }
            foreach (var item in personList)
            {
                Console.WriteLine(item);
            }


            for (int i = 0; i < nameArr.Length; i++)
            {
                Console.WriteLine("Enter name " + (i+1) + ":");
                var nameItem = Console.ReadLine();
                nameArr[i] = nameItem;
            }
            for (int i = nameArr.Length -1; i > -1; i--)
            {
                Console.WriteLine(nameArr[i]);
            }

        }
    }
}  
