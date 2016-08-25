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
            int a, b;
            
         Console.WriteLine("\n Enter the first number: ");
          Program:
            a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

        Console.WriteLine("\n The sum of the 2 numbers is: {0} ", sum);
        
        Console.WriteLine("\n To continue type the first number to exit type Quit  ");
            string quit = System.Console.ReadLine();
        }
    }
}
