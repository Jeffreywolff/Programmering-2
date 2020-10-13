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
            Customer customer = new Customer();
            
            Console.WriteLine("Thank you " + name + "! " +
                "\n Now you will get a visual menu, where you can choose the item you want to" +
                "\n add to your grocery list. Type the name of the product you wanna add: (Example banana)" +
                "\n FRUIT:" +
                "\n Banana" +
                "\n Apple" +
                "\n ANIMAL:" +
                "\n Giraffe" +
                "\n Lion" +
                "\n MEAT:" + 
                "\n Chorizo" +
                "\n exit - Done shopping");
            string choice;

            bool loop = true;
            while (loop)
            {
                var product = new Product();
                var fruit = new Fruit();
                var meat = new Meat();
                var animal = new Animals();
                Console.WriteLine("Enter an item or exit shopping: ");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "banana":
                        product.productType = "Banana";
                        customer._customerCart.Add(product);
                        break;
                    case "giraffe":
                        animal._animalType = "Long horse/ giraffe";
                        customer._customerCart.Add(animal);
                        break;
                    case "lion":

                        product.productType = "Apple";
                        customer._customerCart.Add(product);
                        break;

                    case "chorizo":
                        meat
                        break;

                    case "exit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Thats not a valid input! Try again");
                        break;
                }
                Console.WriteLine( name + " cart:");
                PrintStringList(customer._customerCart);
            }

        }

        public static void PrintStringList(List<Product> list)
        {
            string listItems = "";
            foreach (Product item in list)
            {
                listItems += "//" + item.productType + " \n";
            }
            
            Console.WriteLine(listItems);
        }
    }



}
