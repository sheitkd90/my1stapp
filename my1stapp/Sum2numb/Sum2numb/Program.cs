using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum2numb
{
    class Program
    {
        static void Main()
        {
            //Declaration of variables
            double firstNum;
            double secondNum;
            string command = string.Empty;


            Console.WriteLine("Thank you for using this simple calculator!");
            Console.WriteLine("In order to continue, enter a command:");
            Console.WriteLine("Add");
            Console.WriteLine("Subtract");
            Console.WriteLine("Divide");
            Console.WriteLine("Multiply");
            Console.WriteLine("Quit");

            command = Console.ReadLine();

            while (command != "Quit")
            {
                Console.WriteLine("Please enter the first number:");
                firstNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                secondNum = Convert.ToDouble(Console.ReadLine());

                switch (command)
                {
                    case "Add":
                        Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                        break;
                    case "Subtract":

                        break;
                    case "Divide":

                        break;
                    case "Multiply":

                        break;
                    default:

                        break;
                }
                Console.WriteLine("In order to continue, enter a command:");
                Console.WriteLine("Add");
                Console.WriteLine("Subtract");
                Console.WriteLine("Divide");
                Console.WriteLine("Multiply");
                Console.WriteLine("Quit");
                command = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using this simple calculator!");
        }
    }
}
