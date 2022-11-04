using System;

namespace DailyPractice02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the counts of your array");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] usInput = new string[length];
            Console.WriteLine("Please enter your string");
            for(int i = 0; i < length; i++)
            {
                usInput[i] = Console.ReadLine();
            }
            Console.WriteLine("your array is ");
            foreach (var value in usInput)
            {
                Console.WriteLine(value);

            }
            //reverse the array order
            Array.Reverse(usInput, 0, usInput.Length);

            Console.WriteLine("The reverse of your input is");
            foreach (var value1 in usInput)
            {
                Console.WriteLine(value1);

            }



        }
    }
}
