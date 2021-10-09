using System;

namespace PrimeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,count;
            Console.WriteLine("Enter first number :");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int second = int.Parse(Console.ReadLine());

            for (num = first; num <= second; num++)
            {
                count = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && num != 1)
                    Console.Write(num +" ");
            }
            Console.Write("\n");
        }
        }
    }


