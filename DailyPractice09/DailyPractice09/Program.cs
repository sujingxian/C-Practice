using System;

namespace DailyPractice09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string uInput;
            // Datetime structure should be 2019,12,03 or 2019-12-03 or 2019 12 3 or 2019/12/2
            DateTime date;
            while (true)
            {
                Console.WriteLine("Please enter the string");
                uInput = Console.ReadLine();

                if (uInput == " ")
                
                    break;
                
                if (DateTime.TryParse(uInput, out date))
                {
                    Console.WriteLine(date.ToString(" , , "));
                }
                else
                {
                    Console.WriteLine("it is not a date");
                }
            }
            
            
        }
    }
}
