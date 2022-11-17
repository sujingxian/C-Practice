using System;

namespace DailyPractice13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            byte[] arr = new byte[int.Parse(Console.ReadLine())];
            Random random = new Random();
            random.NextBytes(arr);
            foreach(byte i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
