using System;

namespace DailyPractice12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num;
            string a;

            while (true)
            {
                a = Console.ReadLine();
                if (a == " ")
                {
                    break;
                }
                else
                {
                   
                    num = Convert.ToInt32(a);
                    Console.WriteLine(num);
                    if (num < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else
                    {
                        Console.WriteLine("Positive");
                    }
                }
                
            }
            

            
            
        }
    }
}
