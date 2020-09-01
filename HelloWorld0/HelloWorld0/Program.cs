using System;

namespace HelloWorld0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive;
            String name;
            Console.WriteLine("What is your legal age?");
            var age = Console.ReadLine();
            var intAge = Convert.ToInt32(age);

            Console.WriteLine("What is your legal name?");
            name = Console.ReadLine();

            while (true)
            {   
                Console.WriteLine("Are you alive? Enter Y or N: ");
                var answer = Console.ReadLine();
                if (answer == "Y")
                {
                    alive = true;
                    break;
                }
                else if(answer == "N")
                {
                    alive = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("What is better? \n monday or tuesday:");
            var favDay = Console.ReadLine();
            switch (favDay)
            {
                case "monday":
                    Console.WriteLine("For real? okey boomer!");
                    break;
                case "tuesday":
                    Console.WriteLine("Me too!");
                    break;
                default:
                    Console.WriteLine("Sure, but that was not what I asked!");
                    break;
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
