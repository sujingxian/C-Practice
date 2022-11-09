using System;

namespace DailyPractice07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte[] arr = new byte[10];
            Random random = new Random();

            random.NextBytes(arr);
            Array.Sort(arr);
            Array.Reverse(arr);
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            Console.ReadKey();

        }
    }
}
