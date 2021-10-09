using System;

namespace SelectionSort
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

            for(i=0;i< n-1;i++)
            {
                int min = i;
                for (j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i]=array[min];
                array[min] = temp;
            }

            
            Console.WriteLine("After sorting");
            foreach (int no in array)
            {
                Console.WriteLine(no);
            }
        }
    }
}



