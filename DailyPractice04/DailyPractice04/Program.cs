using System;

namespace DailyPractice04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] myNum = new string[11];
            for(int i=0; i <=10; i++)
            {
                decimal num = 0;
                Console.Write("Please enter the " + i + " number, ");
                myNum[i] = Console.ReadLine();
                bool isNum = decimal.TryParse(myNum[i], out num);
                if (isNum)
                {
                    Console.WriteLine("This number is " + myNum[i]);

                }
                else
                {
                    Console.WriteLine("Please try again");
                    i = i - 1;
                }


                
            }
            foreach(var value in myNum)
            {
                Console.Write(value);
            }
        }
    }
}
