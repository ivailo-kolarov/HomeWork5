using System;

namespace _06.IvailoKolarovMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           

            PersonalInfo("Ivailo", 30);
            PersonalInfo("Pesho", 44);
            PersonalInfo("Gosho", 55);

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int num1 = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            IsinTheArray(arr, number);
            Console.WriteLine(CompareNumbers(num1, number)); 
        }

        public static void PersonalInfo (string name, int age)
            {
            Console.WriteLine($"Hello {name}! You are {age} years old!");
            }

        public static bool IsinTheArray(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == number)
                {
                    Console.WriteLine("The number is in the array!");
                    return true;
                }
          
            }
            Console.WriteLine("The number is not in the array!");
            return false;
          
        }
        public static bool CompareNumbers(int num1, int number)
        {
            if(num1 == number)
            {
                Console.WriteLine("The numbers are equal!");
                return true;
            }
            Console.WriteLine("The numbers are not equal!");
            return false;
        }
        //Console.WriteLine("Test");
    }
}
