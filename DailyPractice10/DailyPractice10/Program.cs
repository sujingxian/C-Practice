using System;

namespace DailyPractice10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int a = random.Next(60, 100);
                Console.WriteLine(a);
                if (a < 76)
                {
                    Console.WriteLine("OK");

                }
                else if (a > 75 && a < 91)
                {
                    Console.WriteLine("Good");
                }
                else if (a > 90)
                {
                    Console.WriteLine("Excellent");
                }
                Console.ReadKey();
            }
            
        }
    }
}
