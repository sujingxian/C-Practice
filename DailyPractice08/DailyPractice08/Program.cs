using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyPractice08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 38, 29, 19, 10, 9, 3, 58, 4, 1 };
            List<int> list = arr.ToList();
            int ans;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                ans = list[random.Next(arr.Length - i)];
                list.Remove(ans);
                Console.Write(ans + " ");
                //list.Remove(ans);


            }
            Console.ReadKey();

        }
    }
}
