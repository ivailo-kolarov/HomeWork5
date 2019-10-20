using System;

namespace IvailoKolarovHW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentense = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            string sentense2 = sentense.Replace(',', ' ');
            Console.WriteLine(sentense2);
            string[] words = sentense2.Split(' ', ' ') ;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
           
        }
    }
}
