using System;

namespace IvailoKolarovHW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentense = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            string[] words = sentense.Split(' ') ;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
           
        }
    }
}
