using System;

namespace _04.SumOfNumbersRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 10 && n <= 100)
            {
                Console.WriteLine(recurSum(n));
            }
            else
            {
                Console.WriteLine("The number is not in the interval [10,100]!");
            }

        }

        public static int recurSum(int n)
        {

            if (n <= 1)
            {

                return n;
            }

            return n + recurSum(n - 1);

        }
    }
}
