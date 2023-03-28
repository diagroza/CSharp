using System;

namespace Homework
{
    class Homework1
    {
        static void Main(string[] args)
        {
            //ex.1
            Console.WriteLine("Enter number 1");
            int number1 = int.Parse(Console.ReadLine());

            if ((number1 % 7 == 0) && (number1 % 10 == 0))
            {
                Console.WriteLine("Number is divisible");
            }
            else
            {
                Console.WriteLine("Number is not divisible");
            }


            //ex.2
            Console.WriteLine("Enter an year");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("We have a leap year");
            }
            else
            {
                Console.WriteLine("It's not a leap year");
            }

            //ex.3 

            Console.WriteLine("This is the last prime number");
            int[] array = new int[] { 2, 3, 5, 7, 11, 13 };
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                {
                    Console.WriteLine(max);
                }

                /*Console.WriteLine("This is the last prime number");
                int[] array = new int[] { 2, 3, 5, 7, 11, 13 };
                int max = 47;
                for (int i = 47; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine(max);*/

                //ex.5
                int num, sum = 0, r;
                Console.WriteLine("Enter a number : ");
                num = int.Parse(Console.ReadLine());
                while (num != 0)
                {
                    r = num % 10;
                    num = num / 10;
                    sum = sum + r;
                }
                Console.WriteLine("Sum of digits are : " + sum);
                Console.ReadLine();
            }



        }
    }
}