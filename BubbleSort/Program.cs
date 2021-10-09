using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 63, 14, 79, 31 };
            int n = 5, i, j, temp;

            Console.WriteLine("Before sorting");
            foreach (int no in array)
            {
                Console.WriteLine(no);
            }

            for (i=0;i<n-1;i++)
            {
                for (j=0;j<n-1;j++)
                {
                    if(array[j]>array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting");
            foreach (int no in array)
            {
                Console.WriteLine(no);
            }

        }
    }
}
