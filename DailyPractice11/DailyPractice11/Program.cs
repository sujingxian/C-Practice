using System;

namespace DailyPractice11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            Random random = new Random();
           
            

            while (true)
            {
                n = random.Next(100, 999);
                Console.WriteLine("The number is " + n);
                int a = n % 10;
                int b = n % 100/10;
                int c = (n / 100) % 10;
                int result = a + b + c;
                Console.WriteLine("the sum is " + result);
                Console.ReadKey();
            }
            

            

        }
    }
}
