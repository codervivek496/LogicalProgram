using System;

namespace LogicalProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nEnter the choice");
                Console.WriteLine("1. print Fibonacci series");
                Console.WriteLine("2. Check perfect number");
                Console.WriteLine("3. Check prime number");
                Console.WriteLine("4. Reverse a number");
                Console.WriteLine("5. Coupon numbers");
                Console.WriteLine("6. Stopwatch");
                Console.WriteLine("0. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.perfect();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckPrime();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        break;
                    case 5:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.Coupon();
                        break;
                    case 6:
                        SimulateStopwatch simulateStopwatch = new SimulateStopwatch();
                        simulateStopwatch.Stopwatch();
                        break;
                }
            } while(choice!= 0);
        }
    }
}
