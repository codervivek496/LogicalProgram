using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write("Enter the end length of fibonacci series: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //printing 0 and 1
            Console.Write("\n" + n1 + " " + n2 + " ");

            for (int i = 2; i < number; i++)  //loop starts from 2 because 0 and 1 already printed
            {
                n3 = n1 + n2;
                Console.Write(+n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
