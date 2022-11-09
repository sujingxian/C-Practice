using System;

namespace DailyPractice06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            //two dimention arra
            long sum = 0;
            // long  -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    arr[i, j] = random.Next();
                    sum += arr[i, j];
                    Console.Write("arr[{0},{1}] = {2}\t", i, j, arr[i,j]);
                }

                Console.WriteLine("sum = {0}", sum);
                sum = 0;
                
                
            }
            Console.ReadKey();

        }
    }
}
