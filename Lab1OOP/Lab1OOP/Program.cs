using System;
using System.Collections.Generic;

namespace Lab1OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to COOP, the best grocery market there is!" +
                "\n Start by Entering your name, so we can associate you with the products!" +
                "\n Enter your name: ");
            string name = Console.ReadLine();
            Customer name1 = new Customer();
            Product items = new Product();
            Console.WriteLine("Thank you " + name + "! " +
                "\n Now you will get a visual menu, where you can choose the item you want to" +
                "\n add to your grocery list. Type the name of the product you wanna add: (Example item1)" +
                "\n item1 - Banana" +
                "\n item2 - Apple" +
                "\n exit - Done shopping");
            string choice;

            int loop = 0;
            while (loop != 1)
            {
                Console.WriteLine("Enter an item or exit shopping: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "item1":
                        name1._customerCart.Add(items.item1);
                        break;
                    case "item2":
                        name1._customerCart.Add(items.item2);
                        break;
                    case "exit":
                        loop = 1;
                        break;
                    default:
                        Console.WriteLine("Thats not a valid input! Try again");
                        break;
                }
                Console.WriteLine( name + " cart:");
                PrintStringList(name1._customerCart);
            }

        }

        public static void PrintStringList(List<string> list)
        {
            string listItems = "";
            foreach (var item in list)
            {
                listItems += "//" + item + " \n";
            }
            
            Console.WriteLine(listItems);
        }
    }



}
