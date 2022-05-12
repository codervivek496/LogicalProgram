using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
     class PrimeNumber
    {
        public void CheckPrime()
        { 
            Console.WriteLine("Enter the number to check Prime or not:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine("{0} is not prime number", number);
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)      
                    {
              
                        Console.WriteLine("{0} is not prime number", number);
                        return;
                    }

                }
                Console.WriteLine("{0} is a prime number", number);
            }
        }
    }
}