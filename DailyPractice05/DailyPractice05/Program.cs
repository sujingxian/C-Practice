using System;

namespace DailyPractice05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string a;
            while (true)
            {
                Console.WriteLine("Please enter a string");
                a = Console.ReadLine();
                char[] s = a.ToCharArray();
                if (s.Length != 5)
                {
                    Console.WriteLine("Please enter 5 letters");

                }
                else
                {
                    bool flag = true;
                    foreach (var value in s)
                    {
                        if (!char.IsUpper(value))
                        {
                            flag = false;
                        }
                        
                    }
                    if (flag)
                    {
                        Console.WriteLine("Yes Upper");
                    }
                    else
                    {
                        Console.WriteLine("Please enter upper");
                    }
                }
            }
            

            
        }
    }
}
