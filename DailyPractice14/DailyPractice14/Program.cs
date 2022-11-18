using System;

namespace DailyPractice14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string txt = Console.ReadLine();
                
                if(txt == " ")
                {
                    break;
                }
                Console.WriteLine("The length of the text is " + txt.Length);
                if (txt.Contains("a"))
                {
                    Console.WriteLine("The text has a");
                }
                if (txt.Contains("A"))
                {
                    Console.WriteLine("The text has A");
                }
                else
                {
                    txt = txt.Insert(0, "A");
                    Console.WriteLine("The text is " + txt);
                }
            }
            
        }
    }
}
