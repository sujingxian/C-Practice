using System;

namespace DailyPractice03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string");
            string a;
            a = Console.ReadLine();
            Console.WriteLine("the string that you input is " + a);

            int Count = 0;
            foreach (char c in a)
            {
                if (c == ' ')
                {
                    Count++;
                }
            }
            int k = Count +1;

            Console.WriteLine("You totally input " + k + "words");
            

        }
    }
}
