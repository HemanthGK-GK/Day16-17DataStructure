using System;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5] { 25, 14, 10, 96, 36 };
            int n = 5,j,i,value,flag;

            foreach(int no in intArray)
            {
                Console.WriteLine(no + " ");
            }

            for ( i=0;i<n;i++)
            {
                value = intArray[i];
                flag = 0;
                for(j=i-1; j>=0 && flag !=1;)
                {
                    if(value < intArray[j])
                    {
                        intArray[j + 1] = intArray[j];
                        j--;
                        intArray[j + 1] = value;

                    }
                    else 
                        flag = 1;

                }
            }
            Console.WriteLine("After Sorting ");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(intArray[i]);
            }

        }
    }
}
