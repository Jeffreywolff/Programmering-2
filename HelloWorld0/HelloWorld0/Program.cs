using System;

namespace HelloWorld0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive;
            var age = Console.ReadLine();
            var name = Console.ReadLine();
            Console.WriteLine("Are you alive? Enter Y or N: ");
            if(Console.ReadLine() == "Y")
            {
                alive = true;
            }
            else
            {
                alive = false;
            }
            if(alive == true)
            {
                Console.WriteLine("You're alive");
            }
            else
            {
                Console.WriteLine("Dead?");
            }
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("And your name is " + name + "!");
            Console.WriteLine("Enter a number:");
            var opt1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            var opt2 = Console.ReadLine();

            //Convert to integer
            var num1 = Convert.ToInt32(opt1);
            var num2 = Convert.ToInt32(opt2);

            Console.WriteLine("This is the bigger number: " + Math.Max(num1, num2));
        }
    }
}
