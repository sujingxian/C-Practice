using System;

namespace Daily_Practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] myNum = new string[10];
            int sum = 0;
            double ave = 0;
            for (int i = 0; i <= 9; i++)
            {

                decimal num = 0;
                Console.WriteLine("Please enter the " + i + " number");
                myNum[i] = Console.ReadLine();
                //判断是否为数字 也可以用isNullorEmpty 和try catch
                bool isNum = decimal.TryParse(myNum[i], out num);
                if (isNum)
                {


                    Console.WriteLine("The first number is " + myNum[i]);

                }
                else
                {
                    Console.WriteLine("Please ");
                    i = i - 1;
                }

                sum += Convert.ToInt32(myNum[i]);


            }
            Console.WriteLine(sum);
            //Calling .ToString() on an array will return "System.String[]". If you want to display each value in the array, you have iterate over it.
            ave = sum / 10;
            Console.WriteLine(ave.ToString("0.000"));
        }
    }
}
