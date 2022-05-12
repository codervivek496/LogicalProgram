using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public void perfect()
        {
            int sum = 0, n;
            Console.Write("Enter the number to check perfect or not: ");
            int number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for(int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum=sum+i;

                }
            }
            if (sum == n)
            {
                Console.WriteLine("{0} is Perfect number", number);
            }
            else
            {
                Console.WriteLine("{0} is not Perfect number", number);
            }
        }
    }
}
